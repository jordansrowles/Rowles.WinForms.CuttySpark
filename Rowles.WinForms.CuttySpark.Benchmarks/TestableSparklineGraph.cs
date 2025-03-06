using System.Windows.Forms;

namespace Rowles.WinForms.CuttySpark.Benchmarks
{
    // Add this derived class in your test project
    internal class TestableSparklineGraph : SparklineGraph
    {
        public void PublicOnPaint(PaintEventArgs e) => base.OnPaint(e);
    }
}