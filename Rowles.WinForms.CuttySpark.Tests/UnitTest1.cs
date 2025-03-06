using Xunit;
using Moq;
using Rowles.WinForms.CuttySpark;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Rowles.WinForms.CuttySpark.Tests
{
    public class SparklineGraphTests
    {
        [Fact]
        public void MaxDataPoints_WhenSet_TrimsExistingData()
        {
            // Arrange
            var sparkline = new SparklineGraph { MaxDataPoints = 5 };

            // Act
            sparkline.AddDataPointAsync(1).Wait();
            sparkline.AddDataPointAsync(2).Wait();
            sparkline.AddDataPointAsync(3).Wait();
            sparkline.AddDataPointAsync(4).Wait();
            sparkline.AddDataPointAsync(5).Wait();
            sparkline.AddDataPointAsync(6).Wait(); // Exceeds limit

            // Assert
            Assert.Equal(5, sparkline.GetDataPoints().Count); // Internal method to expose dataPoints for testing
        }

        [Fact]
        public void ThresholdReached_WhenValueCrossesThreshold_FiresEvent()
        {
            // Arrange
            var sparkline = new SparklineGraph { ThresholdValue = 10 };
            var mockHandler = new Mock<EventHandler<float>>();
            sparkline.ThresholdReached += mockHandler.Object;

            // Act
            sparkline.AddDataPointAsync(5).Wait();
            sparkline.AddDataPointAsync(15).Wait(); // Exceeds threshold

            // Assert
            mockHandler.Verify(h => h(sparkline, 10), Times.Once);
        }

        [Fact]
        public void ComputeStatistics_WithSampleData_ReturnsCorrectValues()
        {
            // Arrange
            var sparkline = new SparklineGraph();
            sparkline.AddDataPointAsync(1).Wait();
            sparkline.AddDataPointAsync(2).Wait();
            sparkline.AddDataPointAsync(3).Wait();

            // Act
            var stats = sparkline.ComputeStatistics();

            // Assert
            Assert.Equal(1, stats.Min);
            Assert.Equal(3, stats.Max);
            Assert.Equal(2, stats.Average);
            Assert.Equal(2, stats.Median);
        }

        [Fact]
        public async Task AddDataPointsAsync_Concurrently_HandlesThreadSafety_Stress()
        {
            // Arrange
            var sparkline = new SparklineGraph { MaxDataPoints = 1000 };
            var tasks = new List<Task>();

            // Act: Add 10,000 points across 10 threads
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(Task.Run(async () =>
                {
                    for (int j = 0; j < 1000; j++)
                        await sparkline.AddDataPointAsync(j);
                }));
            }
            await Task.WhenAll(tasks);

            // Assert
            Assert.True(sparkline.GetDataPoints().Count <= 1000);
            Assert.False(sparkline.GetDataPoints().Any(x => x < 0)); // No invalid data
        }

        [Fact]
        public void AddDataPointAsync_WithNaN_IgnoresInvalidValue_EdgeCase()
        {
            // Arrange
            var sparkline = new SparklineGraph();

            // Act
            sparkline.AddDataPointAsync(float.NaN).Wait();

            // Assert
            Assert.Empty(sparkline.GetDataPoints());
        }

        [Fact]
        public void ShowStatistics_WhenNoData_DoesNotCrash_EdgeCase()
        {
            // Arrange
            var sparkline = new SparklineGraph { ShowStatistics = true };

            // Act & Assert (no exception thrown)
            sparkline.Invalidate(); // Force repaint
        }

        [Fact]
        public void Sparkline_MouseMove_ShowsTooltipForNearestPoint()
        {
            // Arrange
            var sparkline = new SparklineGraph
            {
                Size = new Size(800, 600),  // Set explicit size
                ShowStatistics = false      // Disable status area
            };

            // Add two points that will create predictable screen coordinates
            sparkline.AddDataPointAsync(0).Wait();
            sparkline.AddDataPointAsync(100).Wait();

            // Calculate expected position of second point (right edge, top)
            // Control width: 800, index 1 of 2 points = x = 800
            // Value 100 (max) in 0-100 range = y = 0
            var mousePosition = new Point(795, 5); // Within 5px threshold

            // Act
            sparkline.Sparkline_MouseMove(sparkline,
                new MouseEventArgs(MouseButtons.None, 0, mousePosition.X, mousePosition.Y, 0));

            // Assert
            Assert.NotNull(sparkline.HoveredPoint);
            Assert.Equal(800, sparkline.HoveredPoint.Value.X, precision: 0);
            Assert.Equal(0, sparkline.HoveredPoint.Value.Y, precision: 0);
        }
    }
}