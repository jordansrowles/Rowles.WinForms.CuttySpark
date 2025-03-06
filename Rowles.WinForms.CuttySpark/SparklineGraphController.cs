using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;

namespace Rowles.WinForms.CuttySpark
{
    /// <summary>
    /// A custom control that provides a form–style interface to control selected properties
    /// of a SparklineGraph instance.
    /// </summary>
    [
    Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design",
    typeof(IDesigner))
    ]
    public class SparklineGraphController : UserControl
    {
        private SparklineGraph selectedGraph;

        // UI controls
        private TableLayoutPanel tableLayout;
        private Label lblLineColor;
        private Button btnLineColor;
        private Label lblGridColor;
        private Button btnGridColor;
        private Label lblThresholdColor;
        private Button btnThresholdColor;
        private CheckBox chkShowGrid;
        private CheckBox chkShowThreshold;
        private Label lblThresholdValue;
        private NumericUpDown numThresholdValue;
        private CheckBox chkShowPoints;
        private CheckBox chkSmoothLines;
        private Label lblMaxDataPoints;
        private NumericUpDown numMaxDataPoints;
        private CheckBox chkShowStatistics;
        // Statistics options (assumes SparklineGraph exposes these)
        private GroupBox grpStatisticsOptions;
        private CheckBox chkShowMin;
        private CheckBox chkShowMax;
        private CheckBox chkShowAverage;
        private CheckBox chkShowMedian;
        private CheckBox chkShowRange;
        private CheckBox chkShowStdDev;

        /// <summary>
        /// Gets or sets the SparklineGraph whose properties are controlled by this form.
        /// </summary>
        [
            Category("Sparkline"),
            Description("The SparklineGraph instance to control"),
            Editor(typeof(SparklineGraphEditor), typeof(UITypeEditor))
        ]
        public SparklineGraph SelectedGraph
        {
            get => selectedGraph;
            set
            {
                selectedGraph = value;
                UpdateUIFromGraph();
            }
        }

        public SparklineGraphController()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Builds the UI controls and arranges them in a table layout.
        /// </summary>
        private void InitializeComponent()
        {
            // Create the TableLayoutPanel to host our controls.
            tableLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 11,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(5)
            };

            // Row 0: Line Color
            lblLineColor = new Label { Text = "Line Color:", AutoSize = true };
            btnLineColor = new Button { Text = "Select...", AutoSize = true };
            btnLineColor.Click += BtnLineColor_Click;
            tableLayout.Controls.Add(lblLineColor, 0, 0);
            tableLayout.Controls.Add(btnLineColor, 1, 0);

            // Row 1: Grid Color
            lblGridColor = new Label { Text = "Grid Color:", AutoSize = true };
            btnGridColor = new Button { Text = "Select...", AutoSize = true };
            btnGridColor.Click += BtnGridColor_Click;
            tableLayout.Controls.Add(lblGridColor, 0, 1);
            tableLayout.Controls.Add(btnGridColor, 1, 1);

            // Row 2: Threshold Color
            lblThresholdColor = new Label { Text = "Threshold Color:", AutoSize = true };
            btnThresholdColor = new Button { Text = "Select...", AutoSize = true };
            btnThresholdColor.Click += BtnThresholdColor_Click;
            tableLayout.Controls.Add(lblThresholdColor, 0, 2);
            tableLayout.Controls.Add(btnThresholdColor, 1, 2);

            // Row 3: Show Grid
            chkShowGrid = new CheckBox { Text = "Show Grid", AutoSize = true };
            chkShowGrid.CheckedChanged += (s, e) =>
            {
                if (selectedGraph != null)
                    selectedGraph.ShowGrid = chkShowGrid.Checked;
            };
            tableLayout.Controls.Add(chkShowGrid, 0, 3);
            tableLayout.SetColumnSpan(chkShowGrid, 2);

            // Row 4: Show Threshold
            chkShowThreshold = new CheckBox { Text = "Show Threshold", AutoSize = true };
            chkShowThreshold.CheckedChanged += (s, e) =>
            {
                if (selectedGraph != null)
                    selectedGraph.ShowThreshold = chkShowThreshold.Checked;
            };
            tableLayout.Controls.Add(chkShowThreshold, 0, 4);
            tableLayout.SetColumnSpan(chkShowThreshold, 2);

            // Row 5: Threshold Value
            lblThresholdValue = new Label { Text = "Threshold Value:", AutoSize = true };
            numThresholdValue = new NumericUpDown
            {
                DecimalPlaces = 2,
                Minimum = -1000,
                Maximum = 1000,
                AutoSize = true
            };
            numThresholdValue.ValueChanged += (s, e) =>
            {
                if (selectedGraph != null)
                    selectedGraph.ThresholdValue = (float)numThresholdValue.Value;
            };
            tableLayout.Controls.Add(lblThresholdValue, 0, 5);
            tableLayout.Controls.Add(numThresholdValue, 1, 5);

            // Row 6: Show Points
            chkShowPoints = new CheckBox { Text = "Show Points", AutoSize = true };
            chkShowPoints.CheckedChanged += (s, e) =>
            {
                if (selectedGraph != null)
                    selectedGraph.ShowPoints = chkShowPoints.Checked;
            };
            tableLayout.Controls.Add(chkShowPoints, 0, 6);
            tableLayout.SetColumnSpan(chkShowPoints, 2);

            // Row 7: Smooth Lines
            chkSmoothLines = new CheckBox { Text = "Smooth Lines", AutoSize = true };
            chkSmoothLines.CheckedChanged += (s, e) =>
            {
                if (selectedGraph != null)
                    selectedGraph.SmoothLines = chkSmoothLines.Checked;
            };
            tableLayout.Controls.Add(chkSmoothLines, 0, 7);
            tableLayout.SetColumnSpan(chkSmoothLines, 2);

            // Row 8: Max Data Points
            lblMaxDataPoints = new Label { Text = "Max Data Points:", AutoSize = true };
            numMaxDataPoints = new NumericUpDown
            {
                Minimum = 10,
                Maximum = 1000,
                AutoSize = true
            };
            numMaxDataPoints.ValueChanged += (s, e) =>
            {
                if (selectedGraph != null)
                    selectedGraph.MaxDataPoints = (int)numMaxDataPoints.Value;
            };
            tableLayout.Controls.Add(lblMaxDataPoints, 0, 8);
            tableLayout.Controls.Add(numMaxDataPoints, 1, 8);

            // Row 9: Show Statistics
            chkShowStatistics = new CheckBox { Text = "Show Statistics", AutoSize = true };
            chkShowStatistics.CheckedChanged += (s, e) =>
            {
                if (selectedGraph != null)
                    selectedGraph.ShowStatistics = chkShowStatistics.Checked;
            };
            tableLayout.Controls.Add(chkShowStatistics, 0, 9);
            tableLayout.SetColumnSpan(chkShowStatistics, 2);

            // Row 10: Statistics Options Group
            grpStatisticsOptions = new GroupBox
            {
                Text = "Statistics Options",
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };
            // Create a nested table layout for statistics checkboxes.
            TableLayoutPanel statsLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };
            chkShowMin = new CheckBox { Text = "Show Min", AutoSize = true };
            chkShowMin.CheckedChanged += (s, e) =>
            {
                if (selectedGraph != null)
                    selectedGraph.ShowMin = chkShowMin.Checked;
            };
            statsLayout.Controls.Add(chkShowMin, 0, 0);
            chkShowMax = new CheckBox { Text = "Show Max", AutoSize = true };
            chkShowMax.CheckedChanged += (s, e) =>
            {
                if (selectedGraph != null)
                    selectedGraph.ShowMax = chkShowMax.Checked;
            };
            statsLayout.Controls.Add(chkShowMax, 1, 0);
            chkShowAverage = new CheckBox { Text = "Show Average", AutoSize = true };
            chkShowAverage.CheckedChanged += (s, e) =>
            {
                if (selectedGraph != null)
                    selectedGraph.ShowAverage = chkShowAverage.Checked;
            };
            statsLayout.Controls.Add(chkShowAverage, 0, 1);
            chkShowMedian = new CheckBox { Text = "Show Median", AutoSize = true };
            chkShowMedian.CheckedChanged += (s, e) =>
            {
                if (selectedGraph != null)
                    selectedGraph.ShowMedian = chkShowMedian.Checked;
            };
            statsLayout.Controls.Add(chkShowMedian, 1, 1);
            chkShowRange = new CheckBox { Text = "Show Range", AutoSize = true };
            chkShowRange.CheckedChanged += (s, e) =>
            {
                if (selectedGraph != null)
                    selectedGraph.ShowRange = chkShowRange.Checked;
            };
            statsLayout.Controls.Add(chkShowRange, 0, 2);
            chkShowStdDev = new CheckBox { Text = "Show StdDev", AutoSize = true };
            chkShowStdDev.CheckedChanged += (s, e) =>
            {
                if (selectedGraph != null)
                    selectedGraph.ShowStdDev = chkShowStdDev.Checked;
            };
            statsLayout.Controls.Add(chkShowStdDev, 1, 2);

            grpStatisticsOptions.Controls.Add(statsLayout);
            tableLayout.Controls.Add(grpStatisticsOptions, 0, 10);
            tableLayout.SetColumnSpan(grpStatisticsOptions, 2);

            // Add the table layout to the control.
            this.Controls.Add(tableLayout);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        #region Color Button Event Handlers

        private void BtnLineColor_Click(object sender, EventArgs e)
        {
            if (selectedGraph == null)
                return;
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = selectedGraph.LineColor;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    selectedGraph.LineColor = dlg.Color;
                    btnLineColor.BackColor = dlg.Color;
                    selectedGraph.Invalidate();
                }
            }
        }

        private void BtnGridColor_Click(object sender, EventArgs e)
        {
            if (selectedGraph == null)
                return;
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = selectedGraph.GridColor;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    selectedGraph.GridColor = dlg.Color;
                    btnGridColor.BackColor = dlg.Color;
                    selectedGraph.Invalidate();
                }
            }
        }

        private void BtnThresholdColor_Click(object sender, EventArgs e)
        {
            if (selectedGraph == null)
                return;
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = selectedGraph.ThresholdColor;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    selectedGraph.ThresholdColor = dlg.Color;
                    btnThresholdColor.BackColor = dlg.Color;
                    selectedGraph.Invalidate();
                }
            }
        }

        #endregion

        /// <summary>
        /// Updates the UI controls to match the current property values of the SelectedGraph.
        /// </summary>
        private void UpdateUIFromGraph()
        {
            if (selectedGraph == null)
                return;

            btnLineColor.BackColor = selectedGraph.LineColor;
            btnGridColor.BackColor = selectedGraph.GridColor;
            btnThresholdColor.BackColor = selectedGraph.ThresholdColor;
            chkShowGrid.Checked = selectedGraph.ShowGrid;
            chkShowThreshold.Checked = selectedGraph.ShowThreshold;
            numThresholdValue.Value = (decimal)selectedGraph.ThresholdValue;
            chkShowPoints.Checked = selectedGraph.ShowPoints;
            chkSmoothLines.Checked = selectedGraph.SmoothLines;
            numMaxDataPoints.Value = selectedGraph.MaxDataPoints;
            chkShowStatistics.Checked = selectedGraph.ShowStatistics;

            // Update statistics options (assuming these are defined on SparklineGraph)
            chkShowMin.Checked = selectedGraph.ShowMin;
            chkShowMax.Checked = selectedGraph.ShowMax;
            chkShowAverage.Checked = selectedGraph.ShowAverage;
            chkShowMedian.Checked = selectedGraph.ShowMedian;
            chkShowRange.Checked = selectedGraph.ShowRange;
            chkShowStdDev.Checked = selectedGraph.ShowStdDev;
        }
    }
}