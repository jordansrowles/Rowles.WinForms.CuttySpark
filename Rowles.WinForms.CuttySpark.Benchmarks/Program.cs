using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Rowles.WinForms.CuttySpark;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rowles.WinForms.CuttySpark.Benchmarks
{
    public class SparklineGraphBenchmarks
    {
        private TestableSparklineGraph sparkline;
        private PaintEventArgs paintEventArgs;
        private Bitmap bitmap;
        private Graphics graphics;
        private float[] testData;

        [IterationSetup]
        public void IterationSetup() => GC.Collect();

        [GlobalSetup]
        public void GlobalSetup()
        {
            sparkline = new TestableSparklineGraph
            {
                MaxDataPoints = int.MaxValue,
                Size = new Size(800, 600) // Set explicit size
            };

            testData = Enumerable.Range(0, DataSize).Select(x => (float)x).ToArray();

            // Setup painting resources
            bitmap = new Bitmap(sparkline.Width, sparkline.Height);
            graphics = Graphics.FromImage(bitmap);
            paintEventArgs = new PaintEventArgs(graphics, new Rectangle(0, 0, sparkline.Width, sparkline.Height));
        }

        [Benchmark]
        public void RenderSparkline()
        {
            sparkline.UpdateDataAsync(testData).Wait();
            sparkline.PublicOnPaint(paintEventArgs);
        }

        [Params(100, 1_000)]
        public int DataSize { get; set; }



        [GlobalCleanup]
        public void GlobalCleanup()
        {
            graphics?.Dispose();
            bitmap?.Dispose();
        }

        [Benchmark]
        public async Task AddSingleDataPointAsync()
        {
            await sparkline.AddDataPointAsync(1.0f);
        }

        [Benchmark]
        public async Task AddBulkDataPointsAsync()
        {
            await sparkline.AddDataPointAsync(testData);
        }


        [Benchmark]
        public void ComputeStatisticsBenchmark()
        {
            sparkline.UpdateDataAsync(testData).Wait();
            var stats = sparkline.ComputeStatistics();
        }

        [Benchmark]
        public void FullWorkflow()
        {
            sparkline.UpdateDataAsync(testData).Wait();
            sparkline.PublicOnPaint(paintEventArgs);
            var stats = sparkline.ComputeStatistics();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<SparklineGraphBenchmarks>();
        }
    }
}