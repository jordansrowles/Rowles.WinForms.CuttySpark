using Rowles.WinForms.CuttySpark;
using System;

namespace ExampleApp
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer dataTimer = new System.Windows.Forms.Timer { Interval = 900 };
        System.Windows.Forms.Timer dataTimer2 = new System.Windows.Forms.Timer { Interval = 600 };

        System.Windows.Forms.Timer dataTimer3 = new System.Windows.Forms.Timer { Interval = 1 };

        public Form1()
        {
            InitializeComponent();

            // ctrl 1
            dataTimer.Tick += async (s, e) =>
            {
                await AddRandomDataPointAsync(sparklineGraph1);
            };
            dataTimer.Start();

            //ctrl2
            dataTimer2.Tick += async (s, e) =>
            {
                await AddRandomDataPointAsync(sparklineGraph2);
            };
            dataTimer2.Start();

            //ctrl group
            dataTimer3.Tick += async (s, e) =>
            {

                foreach (SparklineGraph ctrl in groupBox1.Controls)
                {
                    await AddRandomDataPointAsync(ctrl);
                }
            };
            dataTimer3.Start();
        }

        private async Task AddRandomDataPointAsync(SparklineGraph graph)
        {
            Random rnd = new();
            float newValue = rnd.Next(10, 100);
            await graph.AddDataPointAsync(newValue);
        }

    }
}
