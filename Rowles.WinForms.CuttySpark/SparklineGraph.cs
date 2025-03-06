using System.ComponentModel;
using System.Diagnostics;

namespace Rowles.WinForms.CuttySpark
{
    public partial class SparklineGraph : UserControl
    {
        private const float Epsilon = 1e-6f; // Safeguard for near-zero ranges
        private List<float> dataPoints = new();
        private readonly object lockObj = new();
        private readonly ToolTip tooltip = new();
        private PointF? hoveredPoint = null;
        private bool thresholdFired = false;
        private int maxDataPoints = 50;

        /// <summary>
        /// Fired when a data point exceeds the threshold value.
        /// </summary>
        public event EventHandler<float> ThresholdReached;

        public SparklineGraph()
        {
            InitializeComponent();
            DoubleBuffered = true;
            Resize += (s, e) => Invalidate();
            MouseMove += Sparkline_MouseMove;
            MouseLeave += (s, e) =>
            {
                hoveredPoint = null;
                tooltip.Hide(this);
                Invalidate();
            };

            BackColor = Color.White;
            LineColor = Color.Blue;
            GridColor = Color.LightGray;
            ThresholdColor = Color.Red;
            PointColor = Color.Red;
        }

        #region General Properties

        internal PointF? HoveredPoint => hoveredPoint;

        [Category("Behavior")]
        [Description("Maximum number of data points displayed")]
        [DefaultValue(50)]
        public int MaxDataPoints
        {
            get => maxDataPoints;
            set { maxDataPoints = value; TrimData(); Invalidate(); }
        }

        [Category("Appearance")]
        [Description("Show tooltips when hovering points")]
        [DefaultValue(true)]
        public bool ShowTooltips { get; set; } = true;

        [Category("Appearance")]
        [Description("Show data point markers")]
        [DefaultValue(true)]
        public bool ShowPoints { get; set; } = true;

        [Category("Appearance")]
        [Description("Show background grid")]
        [DefaultValue(true)]
        public bool ShowGrid { get; set; } = true;

        [Category("Appearance")]
        [Description("Sparkline color")]
        public Color LineColor { get; set; }

        [Category("Appearance")]
        [Description("Grid line color")]
        public Color GridColor { get; set; }

        [Category("Appearance")]
        [Description("Data point color")]
        public Color PointColor { get; set; }

        [Category("Threshold")]
        [Description("Threshold line color")]
        public Color ThresholdColor { get; set; }

        [Category("Threshold")]
        [Description("Show threshold line")]
        [DefaultValue(false)]
        public bool ShowThreshold { get; set; }

        [Category("Threshold")]
        [Description("Threshold value")]
        [DefaultValue(float.NaN)]
        public float ThresholdValue { get; set; } = float.NaN;

        [Category("Appearance")]
        [Description("Number of vertical grid lines")]
        [DefaultValue(10)]
        public int GridLinesVertical { get; set; } = 10;

        [Category("Appearance")]
        [Description("Number of horizontal grid lines")]
        [DefaultValue(5)]
        public int GridLinesHorizontal { get; set; } = 5;

        [Category("Appearance")]
        [Description("Use smooth curves for the sparkline")]
        [DefaultValue(false)]
        public bool SmoothLines { get; set; }

        [Category("Appearance")]
        [Description("Control background color")]
        public override Color BackColor
        {
            get => base.BackColor;
            set { base.BackColor = value; Invalidate(); }
        }

        #endregion

        #region Statistics Properties

        // Toggle the entire status area
        [Category("Statistics")]
        [Description("Show statistics in a status area at the bottom")]
        [DefaultValue(false)]
        public bool ShowStatistics { get; set; } = false;

        [Category("Statistics")]
        [Description("Show minimum value")]
        [DefaultValue(true)]
        public bool ShowMin { get; set; } = true;

        [Category("Statistics")]
        [Description("Show maximum value")]
        [DefaultValue(true)]
        public bool ShowMax { get; set; } = true;

        [Category("Statistics")]
        [Description("Show average value")]
        [DefaultValue(true)]
        public bool ShowAverage { get; set; } = true;

        [Category("Statistics")]
        [Description("Show median value")]
        [DefaultValue(true)]
        public bool ShowMedian { get; set; } = true;

        [Category("Statistics")]
        [Description("Show range (max - min)")]
        [DefaultValue(true)]
        public bool ShowRange { get; set; } = true;

        [Category("Statistics")]
        [Description("Show standard deviation")]
        [DefaultValue(true)]
        public bool ShowStdDev { get; set; } = true;

        [Category("Statistics")]
        [Description("Show lower quartile (25th percentile)")]
        [DefaultValue(true)]
        public bool ShowLowerQuartile { get; set; } = true;

        [Category("Statistics")]
        [Description("Show upper quartile (75th percentile)")]
        [DefaultValue(true)]
        public bool ShowUpperQuartile { get; set; } = true;

        [Category("Statistics")]
        [Description("Show interquartile range (IQR)")]
        [DefaultValue(true)]
        public bool ShowIQR { get; set; } = true;

        [Category("Statistics")]
        [Description("Show mode (most frequent value)")]
        [DefaultValue(true)]
        public bool ShowMode { get; set; } = true;

        [Category("Statistics")]
        [Description("Show coefficient of variation (std dev / average)")]
        [DefaultValue(true)]
        public bool ShowCoefficientOfVariation { get; set; } = true;

        #endregion

        #region Data Update Methods

        /// <summary>
        /// Replaces the current data points with the provided array asynchronously.
        /// </summary>
        public async Task UpdateDataAsync(float[] newData)
        {
            if (newData == null || newData.Length < 2)
                return;

            await UpdateDataInternalAsync(() =>
            {
                dataPoints = newData.ToList();
            });
        }

        /// <summary>
        /// Adds a single data point asynchronously.
        /// </summary>
        public async Task AddDataPointAsync(float newData)
        {
            await UpdateDataInternalAsync(() =>
            {
                dataPoints.Add(newData);
            });
        }

        /// <summary>
        /// Adds multiple data points asynchronously.
        /// </summary>
        public async Task AddDataPointAsync(float[] newData)
        {
            if (newData == null || newData.Length == 0)
                return;

            await UpdateDataInternalAsync(() =>
            {
                dataPoints.AddRange(newData);
            });
        }

        #endregion

        #region Painting & Layout

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(BackColor);

            // Compute statistics (if needed for measuring text)
            Statistics stats = null;
            string statsText = string.Empty;
            int statusHeight = 0;
            if (ShowStatistics)
            {
                stats = ComputeStatistics();
                statsText = BuildStatisticText(stats);
                // Measure the text; constrain the width to the control width.
                SizeF measured = g.MeasureString(statsText, Font, Width);
                // Add a small padding (e.g., 4 pixels)
                statusHeight = (int)Math.Ceiling(measured.Height) + 4;
            }

            // Define the chart area (sparkline drawing area) as the remaining space.
            Rectangle chartRect = new Rectangle(0, 0, Width, Height - statusHeight);
            if (ShowGrid)
                DrawGrid(g, chartRect);
            DrawThreshold(g, chartRect);
            DrawSparkline(g, chartRect);

            // Draw the status area if enabled.
            if (ShowStatistics && stats != null)
            {
                Rectangle statusRect = new Rectangle(0, Height - statusHeight, Width, statusHeight);
                DrawStatusArea(g, statusRect, stats);
            }
        }

        #endregion

        #region Private/Internal Helper Methods

        /// <summary>
        /// Retrieves a copy of the current data points displayed in the sparkline graph.
        /// </summary>
        /// <returns>A new list containing the current data points. Modifications to this list will not affect the control's internal state.</returns>
        /// <remarks>
        /// This method is thread-safe and returns a snapshot of the data points at the time of invocation.
        /// </remarks>
        internal List<float> GetDataPoints()
        {
            lock (lockObj)
            {
                return new List<float>(dataPoints);
            }
        }

        /// <summary>
        /// Updates data in a thread-safe manner.
        /// </summary>
        private async Task UpdateDataInternalAsync(Action updateAction)
        {
            try
            {
                await Task.Run(() =>
                {
                    lock (lockObj)
                    {
                        updateAction();
                        TrimData();
                        CheckThreshold();
                    }
                });
                Invalidate();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error updating data: " + ex.Message);
            }
        }

        /// <summary>
        /// Trims dataPoints to ensure the count doesn't exceed MaxDataPoints.
        /// </summary>
        private void TrimData()
        {
            while (dataPoints.Count > MaxDataPoints)
                dataPoints.RemoveAt(0);
        }

        /// <summary>
        /// Fires ThresholdReached event if any value exceeds ThresholdValue.
        /// </summary>
        private void CheckThreshold()
        {
            if (float.IsNaN(ThresholdValue))
                return;

            bool exceeded = dataPoints.Any(v => v >= ThresholdValue);
            if (exceeded && !thresholdFired)
            {
                ThresholdReached?.Invoke(this, ThresholdValue);
                thresholdFired = true;
            }
            else if (!exceeded)
            {
                thresholdFired = false;
            }
        }

        /// <summary>
        /// Draws a background grid within the specified area.
        /// </summary>
        private void DrawGrid(Graphics g, Rectangle area)
        {
            using var gridPen = new Pen(GridColor, 1);
            float stepX = area.Width / (float)GridLinesVertical;
            float stepY = area.Height / (float)GridLinesHorizontal;

            for (int i = 1; i < GridLinesVertical; i++)
                g.DrawLine(gridPen, area.Left + i * stepX, area.Top, area.Left + i * stepX, area.Bottom);

            for (int i = 1; i < GridLinesHorizontal; i++)
                g.DrawLine(gridPen, area.Left, area.Top + i * stepY, area.Right, area.Top + i * stepY);
        }

        /// <summary>
        /// Draws the threshold line within the specified area.
        /// </summary>
        private void DrawThreshold(Graphics g, Rectangle area)
        {
            if (!ShowThreshold || float.IsNaN(ThresholdValue) || dataPoints.Count < 2)
                return;

            (float min, float max, float range) = GetDataMetrics();
            float yThreshold = area.Height - ((ThresholdValue - min) / range) * area.Height;
            using var thresholdPen = new Pen(ThresholdColor, 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
            g.DrawLine(thresholdPen, area.Left, area.Top + yThreshold, area.Right, area.Top + yThreshold);
        }

        /// <summary>
        /// Draws the sparkline (with markers and hover highlight) within the specified area.
        /// </summary>
        private void DrawSparkline(Graphics g, Rectangle area)
        {
            PointF[] points;
            lock (lockObj)
            {
                if (dataPoints.Count < 2)
                    return;

                (float min, float max, float range) = GetDataMetrics();
                points = dataPoints.Select((v, i) => ConvertToPoint(i, v, min, range, area))
                                   .ToArray();
            }

            using var linePen = new Pen(LineColor, 2);
            if (SmoothLines)
                g.DrawCurve(linePen, points);
            else
                g.DrawLines(linePen, points);

            if (ShowPoints)
            {
                float pointSize = ScaleX(6);
                using var pointBrush = new SolidBrush(PointColor);
                foreach (var p in points)
                    g.FillEllipse(pointBrush, p.X - pointSize / 2, p.Y - pointSize / 2, pointSize, pointSize);
            }

            if (hoveredPoint.HasValue)
            {
                float highlightSize = ScaleX(8);
                using var highlightPen = new Pen(Color.Black, 2);
                g.DrawEllipse(highlightPen,
                    hoveredPoint.Value.X - highlightSize / 2,
                    hoveredPoint.Value.Y - highlightSize / 2,
                    highlightSize, highlightSize);
            }
        }

        /// <summary>
        /// Converts a data point into a screen coordinate within the given area.
        /// </summary>
        private PointF ConvertToPoint(int index, float value, float min, float range, Rectangle area)
        {
            float x = (area.Width * index) / (float)(dataPoints.Count - 1);
            float y = area.Height - ((value - min) / range) * area.Height;
            return new PointF(area.Left + x, area.Top + y);
        }

        /// <summary>
        /// Returns the minimum, maximum, and range of dataPoints.
        /// </summary>
        private (float min, float max, float range) GetDataMetrics()
        {
            float min = dataPoints.Min();
            float max = dataPoints.Max();
            float range = max - min;
            if (Math.Abs(range) < Epsilon)
                range = 1;
            return (min, max, range);
        }

        /// <summary>
        /// Handles mouse movement to show tooltips and highlight the closest data point.
        /// Only considers positions within the chart area.
        /// </summary>
        internal void Sparkline_MouseMove(object sender, MouseEventArgs e)
        {
            // Skip if mouse is in the status area.
            int statusAreaHeight = ShowStatistics ? (int)Math.Ceiling(Font.GetHeight() + 4) : 0;
            if (ShowStatistics && e.Y > Height - statusAreaHeight)
                return;

            if (!ShowTooltips)
                return;

            PointF? newHovered = null;
            string tooltipText = null;

            lock (lockObj)
            {
                if (dataPoints.Count < 2)
                    return;

                (float min, float max, float range) = GetDataMetrics();
                // Use the entire control width for hit-testing
                Rectangle chartArea = new Rectangle(0, 0, Width, Height - statusAreaHeight);
                for (int i = 0; i < dataPoints.Count; i++)
                {
                    var point = ConvertToPoint(i, dataPoints[i], min, range, chartArea);
                    if (Distance(e.Location, point) < ScaleX(5))
                    {
                        newHovered = point;
                        tooltipText = $"Value: {dataPoints[i]:F2}";
                        break;
                    }
                }
            }

            if (newHovered.HasValue)
            {
                hoveredPoint = newHovered;
                tooltip.Show(tooltipText, this,
                    e.X + SystemInformation.CursorSize.Width, e.Y);
            }
            else
            {
                hoveredPoint = null;
                tooltip.Hide(this);
            }
            Invalidate();
        }

        /// <summary>
        /// Scales a value for DPI.
        /// </summary>
        private float ScaleX(float value) => value * (DeviceDpi / 96f);

        /// <summary>
        /// Returns the Euclidean distance between a Point and a PointF.
        /// </summary>
        private float Distance(Point a, PointF b) =>
            (float)Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));

        #endregion

        #region Statistics Computation and Rendering

        /// <summary>
        /// Holds computed statistical measures.
        /// </summary>
        internal class Statistics
        {
            public float Min { get; set; }
            public float Max { get; set; }
            public float Average { get; set; }
            public float Median { get; set; }
            public float Range { get; set; }
            public float StandardDeviation { get; set; }
            public float LowerQuartile { get; set; }
            public float UpperQuartile { get; set; }
            public float IQR { get; set; }
            public float Mode { get; set; }
            public float CoefficientOfVariation { get; set; }
        }

        /// <summary>
        /// Computes statistics (min, max, average, median, range, standard deviation,
        /// quartiles, IQR, mode, coefficient of variation) from the data points.
        /// </summary>
        internal Statistics ComputeStatistics()
        {
            lock (lockObj)
            {
                if (dataPoints.Count == 0)
                    return null;

                var sorted = dataPoints.OrderBy(x => x).ToList();
                int count = sorted.Count;
                float min = sorted.First();
                float max = sorted.Last();
                float average = dataPoints.Average();
                float median = CalculatePercentile(sorted, 50);
                float lowerQuartile = CalculatePercentile(sorted, 25);
                float upperQuartile = CalculatePercentile(sorted, 75);
                float range = max - min;
                float iqr = upperQuartile - lowerQuartile;
                float stdDev = (float)Math.Sqrt(dataPoints.Sum(x => Math.Pow(x - average, 2)) / count);
                float coefficient = Math.Abs(average) > Epsilon ? stdDev / average : 0;
                float mode = CalculateMode(dataPoints);

                return new Statistics
                {
                    Min = min,
                    Max = max,
                    Average = average,
                    Median = median,
                    Range = range,
                    StandardDeviation = stdDev,
                    LowerQuartile = lowerQuartile,
                    UpperQuartile = upperQuartile,
                    IQR = iqr,
                    Mode = mode,
                    CoefficientOfVariation = coefficient
                };
            }
        }

        /// <summary>
        /// Calculates the specified percentile using linear interpolation.
        /// </summary>
        private float CalculatePercentile(List<float> sortedData, float percentile)
        {
            if (sortedData == null || sortedData.Count == 0)
                return 0;

            float p = percentile / 100f;
            int n = sortedData.Count;
            float pos = (n - 1) * p;
            int index = (int)Math.Floor(pos);
            float fraction = pos - index;

            if (index + 1 < n)
                return sortedData[index] + fraction * (sortedData[index + 1] - sortedData[index]);
            else
                return sortedData[index];
        }

        /// <summary>
        /// Calculates the mode (most frequent value) from the data points.
        /// </summary>
        private float CalculateMode(List<float> data)
        {
            if (data == null || data.Count == 0)
                return 0;

            var groups = data.GroupBy(x => x)
                             .Select(g => new { Value = g.Key, Count = g.Count() })
                             .OrderByDescending(g => g.Count)
                             .ThenBy(g => g.Value)
                             .ToList();
            return groups.First().Value;
        }

        /// <summary>
        /// Builds the statistics text based on enabled properties.
        /// </summary>
        private string BuildStatisticText(Statistics stats)
        {
            if (stats == null)
                return string.Empty;

            List<string> parts = new List<string>();

            if (ShowMin)
                parts.Add($"Min: {stats.Min:F2}");
            if (ShowMax)
                parts.Add($"Max: {stats.Max:F2}");
            if (ShowAverage)
                parts.Add($"Avg: {stats.Average:F2}");
            if (ShowMedian)
                parts.Add($"Med: {stats.Median:F2}");
            if (ShowRange)
                parts.Add($"Range: {stats.Range:F2}");
            if (ShowStdDev)
                parts.Add($"StdDev: {stats.StandardDeviation:F2}");
            if (ShowLowerQuartile)
                parts.Add($"Q1: {stats.LowerQuartile:F2}");
            if (ShowUpperQuartile)
                parts.Add($"Q3: {stats.UpperQuartile:F2}");
            if (ShowIQR)
                parts.Add($"IQR: {stats.IQR:F2}");
            if (ShowMode)
                parts.Add($"Mode: {stats.Mode:F2}");
            if (ShowCoefficientOfVariation)
                parts.Add($"CV: {stats.CoefficientOfVariation:F2}");

            return string.Join("  |  ", parts);
        }


        /// <summary>
        /// Draws the statistics status area in the specified rectangle.
        /// </summary>
        private void DrawStatusArea(Graphics g, Rectangle statusRect, Statistics stats)
        {
            // Fill the background.
            using (var bgBrush = new SolidBrush(Color.WhiteSmoke))
            {
                g.FillRectangle(bgBrush, statusRect);
            }

            string statText = BuildStatisticText(stats);

            // Center the text. If the text wraps, MeasureString ensures we get the full height.
            using (var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                g.DrawString(statText, Font, Brushes.Black, statusRect, sf);
            }
        }

        #endregion
    }
}
