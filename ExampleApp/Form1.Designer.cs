using Rowles.WinForms.CuttySpark;

namespace ExampleApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sparklineGraph1 = new SparklineGraph();
            sparklineGraph2 = new SparklineGraph();
            sparklineGraphController1 = new SparklineGraphController();
            sparklineGraphController2 = new SparklineGraphController();
            panel1 = new Panel();
            panel2 = new Panel();
            sparklineGraph3 = new SparklineGraph();
            sparklineGraph4 = new SparklineGraph();
            sparklineGraph5 = new SparklineGraph();
            sparklineGraph6 = new SparklineGraph();
            sparklineGraph7 = new SparklineGraph();
            sparklineGraph8 = new SparklineGraph();
            sparklineGraph9 = new SparklineGraph();
            sparklineGraph10 = new SparklineGraph();
            sparklineGraph11 = new SparklineGraph();
            sparklineGraph12 = new SparklineGraph();
            sparklineGraph13 = new SparklineGraph();
            sparklineGraph14 = new SparklineGraph();
            groupBox1 = new GroupBox();
            sparklineGraph48 = new SparklineGraph();
            sparklineGraph49 = new SparklineGraph();
            sparklineGraph50 = new SparklineGraph();
            sparklineGraph54 = new SparklineGraph();
            sparklineGraph55 = new SparklineGraph();
            sparklineGraph56 = new SparklineGraph();
            sparklineGraph57 = new SparklineGraph();
            sparklineGraph58 = new SparklineGraph();
            sparklineGraph59 = new SparklineGraph();
            sparklineGraph60 = new SparklineGraph();
            sparklineGraph61 = new SparklineGraph();
            sparklineGraph62 = new SparklineGraph();
            sparklineGraph63 = new SparklineGraph();
            sparklineGraph64 = new SparklineGraph();
            sparklineGraph65 = new SparklineGraph();
            sparklineGraph39 = new SparklineGraph();
            sparklineGraph40 = new SparklineGraph();
            sparklineGraph41 = new SparklineGraph();
            sparklineGraph42 = new SparklineGraph();
            sparklineGraph43 = new SparklineGraph();
            sparklineGraph44 = new SparklineGraph();
            sparklineGraph45 = new SparklineGraph();
            sparklineGraph46 = new SparklineGraph();
            sparklineGraph47 = new SparklineGraph();
            sparklineGraph27 = new SparklineGraph();
            sparklineGraph28 = new SparklineGraph();
            sparklineGraph29 = new SparklineGraph();
            sparklineGraph30 = new SparklineGraph();
            sparklineGraph31 = new SparklineGraph();
            sparklineGraph32 = new SparklineGraph();
            sparklineGraph33 = new SparklineGraph();
            sparklineGraph34 = new SparklineGraph();
            sparklineGraph35 = new SparklineGraph();
            sparklineGraph36 = new SparklineGraph();
            sparklineGraph37 = new SparklineGraph();
            sparklineGraph38 = new SparklineGraph();
            sparklineGraph15 = new SparklineGraph();
            sparklineGraph16 = new SparklineGraph();
            sparklineGraph17 = new SparklineGraph();
            sparklineGraph18 = new SparklineGraph();
            sparklineGraph19 = new SparklineGraph();
            sparklineGraph20 = new SparklineGraph();
            sparklineGraph21 = new SparklineGraph();
            sparklineGraph22 = new SparklineGraph();
            sparklineGraph23 = new SparklineGraph();
            sparklineGraph24 = new SparklineGraph();
            sparklineGraph25 = new SparklineGraph();
            sparklineGraph26 = new SparklineGraph();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // sparklineGraph1
            // 
            sparklineGraph1.BackColor = Color.White;
            sparklineGraph1.Dock = DockStyle.Top;
            sparklineGraph1.GridColor = Color.LightGray;
            sparklineGraph1.LineColor = Color.Blue;
            sparklineGraph1.Location = new Point(0, 225);
            sparklineGraph1.Name = "sparklineGraph1";
            sparklineGraph1.PointColor = Color.Red;
            sparklineGraph1.ShowStatistics = true;
            sparklineGraph1.Size = new Size(1047, 225);
            sparklineGraph1.TabIndex = 0;
            sparklineGraph1.ThresholdColor = Color.Red;
            sparklineGraph1.ThresholdValue = -1000F;
            // 
            // sparklineGraph2
            // 
            sparklineGraph2.BackColor = Color.White;
            sparklineGraph2.Dock = DockStyle.Top;
            sparklineGraph2.GridColor = Color.LightGray;
            sparklineGraph2.LineColor = Color.Blue;
            sparklineGraph2.Location = new Point(0, 0);
            sparklineGraph2.Name = "sparklineGraph2";
            sparklineGraph2.PointColor = Color.Red;
            sparklineGraph2.ShowPoints = false;
            sparklineGraph2.ShowStatistics = true;
            sparklineGraph2.ShowThreshold = true;
            sparklineGraph2.Size = new Size(1047, 225);
            sparklineGraph2.TabIndex = 1;
            sparklineGraph2.ThresholdColor = Color.Red;
            sparklineGraph2.ThresholdValue = 50F;
            // 
            // sparklineGraphController1
            // 
            sparklineGraphController1.AutoSize = true;
            sparklineGraphController1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sparklineGraphController1.Dock = DockStyle.Left;
            sparklineGraphController1.Location = new Point(332, 0);
            sparklineGraphController1.Margin = new Padding(5, 6, 5, 6);
            sparklineGraphController1.Name = "sparklineGraphController1";
            sparklineGraphController1.SelectedGraph = sparklineGraph1;
            sparklineGraphController1.Size = new Size(332, 570);
            sparklineGraphController1.TabIndex = 2;
            // 
            // sparklineGraphController2
            // 
            sparklineGraphController2.AutoSize = true;
            sparklineGraphController2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sparklineGraphController2.Dock = DockStyle.Left;
            sparklineGraphController2.Location = new Point(0, 0);
            sparklineGraphController2.Margin = new Padding(5, 6, 5, 6);
            sparklineGraphController2.Name = "sparklineGraphController2";
            sparklineGraphController2.SelectedGraph = sparklineGraph2;
            sparklineGraphController2.Size = new Size(332, 570);
            sparklineGraphController2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(sparklineGraph1);
            panel1.Controls.Add(sparklineGraph2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 1024);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(sparklineGraphController1);
            panel2.Controls.Add(sparklineGraphController2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 450);
            panel2.Name = "panel2";
            panel2.Size = new Size(1047, 570);
            panel2.TabIndex = 2;
            // 
            // sparklineGraph3
            // 
            sparklineGraph3.BackColor = Color.Black;
            sparklineGraph3.GridColor = Color.LightGray;
            sparklineGraph3.LineColor = Color.ForestGreen;
            sparklineGraph3.Location = new Point(15, 30);
            sparklineGraph3.MaxDataPoints = 150;
            sparklineGraph3.Name = "sparklineGraph3";
            sparklineGraph3.PointColor = Color.Red;
            sparklineGraph3.ShowGrid = false;
            sparklineGraph3.ShowPoints = false;
            sparklineGraph3.ShowTooltips = false;
            sparklineGraph3.Size = new Size(203, 56);
            sparklineGraph3.SmoothLines = true;
            sparklineGraph3.TabIndex = 5;
            sparklineGraph3.ThresholdColor = Color.Red;
            sparklineGraph3.ThresholdValue = -1000F;
            // 
            // sparklineGraph4
            // 
            sparklineGraph4.BackColor = Color.Black;
            sparklineGraph4.GridColor = Color.LightGray;
            sparklineGraph4.LineColor = Color.ForestGreen;
            sparklineGraph4.Location = new Point(15, 92);
            sparklineGraph4.MaxDataPoints = 150;
            sparklineGraph4.Name = "sparklineGraph4";
            sparklineGraph4.PointColor = Color.Red;
            sparklineGraph4.ShowGrid = false;
            sparklineGraph4.ShowPoints = false;
            sparklineGraph4.ShowTooltips = false;
            sparklineGraph4.Size = new Size(203, 56);
            sparklineGraph4.SmoothLines = true;
            sparklineGraph4.TabIndex = 6;
            sparklineGraph4.ThresholdColor = Color.Red;
            // 
            // sparklineGraph5
            // 
            sparklineGraph5.BackColor = Color.Black;
            sparklineGraph5.GridColor = Color.LightGray;
            sparklineGraph5.LineColor = Color.ForestGreen;
            sparklineGraph5.Location = new Point(15, 154);
            sparklineGraph5.MaxDataPoints = 150;
            sparklineGraph5.Name = "sparklineGraph5";
            sparklineGraph5.PointColor = Color.Red;
            sparklineGraph5.ShowGrid = false;
            sparklineGraph5.ShowPoints = false;
            sparklineGraph5.ShowTooltips = false;
            sparklineGraph5.Size = new Size(203, 56);
            sparklineGraph5.SmoothLines = true;
            sparklineGraph5.TabIndex = 7;
            sparklineGraph5.ThresholdColor = Color.Red;
            // 
            // sparklineGraph6
            // 
            sparklineGraph6.BackColor = Color.Black;
            sparklineGraph6.GridColor = Color.LightGray;
            sparklineGraph6.LineColor = Color.ForestGreen;
            sparklineGraph6.Location = new Point(15, 216);
            sparklineGraph6.MaxDataPoints = 150;
            sparklineGraph6.Name = "sparklineGraph6";
            sparklineGraph6.PointColor = Color.Red;
            sparklineGraph6.ShowGrid = false;
            sparklineGraph6.ShowPoints = false;
            sparklineGraph6.ShowTooltips = false;
            sparklineGraph6.Size = new Size(203, 56);
            sparklineGraph6.SmoothLines = true;
            sparklineGraph6.TabIndex = 8;
            sparklineGraph6.ThresholdColor = Color.Red;
            // 
            // sparklineGraph7
            // 
            sparklineGraph7.BackColor = Color.Black;
            sparklineGraph7.GridColor = Color.LightGray;
            sparklineGraph7.LineColor = Color.ForestGreen;
            sparklineGraph7.Location = new Point(15, 464);
            sparklineGraph7.MaxDataPoints = 150;
            sparklineGraph7.Name = "sparklineGraph7";
            sparklineGraph7.PointColor = Color.Red;
            sparklineGraph7.ShowGrid = false;
            sparklineGraph7.ShowPoints = false;
            sparklineGraph7.ShowTooltips = false;
            sparklineGraph7.Size = new Size(203, 56);
            sparklineGraph7.SmoothLines = true;
            sparklineGraph7.TabIndex = 13;
            sparklineGraph7.ThresholdColor = Color.Red;
            // 
            // sparklineGraph8
            // 
            sparklineGraph8.BackColor = Color.Black;
            sparklineGraph8.GridColor = Color.LightGray;
            sparklineGraph8.LineColor = Color.ForestGreen;
            sparklineGraph8.Location = new Point(15, 402);
            sparklineGraph8.MaxDataPoints = 150;
            sparklineGraph8.Name = "sparklineGraph8";
            sparklineGraph8.PointColor = Color.Red;
            sparklineGraph8.ShowGrid = false;
            sparklineGraph8.ShowPoints = false;
            sparklineGraph8.ShowTooltips = false;
            sparklineGraph8.Size = new Size(203, 56);
            sparklineGraph8.SmoothLines = true;
            sparklineGraph8.TabIndex = 12;
            sparklineGraph8.ThresholdColor = Color.Red;
            // 
            // sparklineGraph9
            // 
            sparklineGraph9.BackColor = Color.Black;
            sparklineGraph9.GridColor = Color.LightGray;
            sparklineGraph9.LineColor = Color.ForestGreen;
            sparklineGraph9.Location = new Point(15, 340);
            sparklineGraph9.MaxDataPoints = 150;
            sparklineGraph9.Name = "sparklineGraph9";
            sparklineGraph9.PointColor = Color.Red;
            sparklineGraph9.ShowGrid = false;
            sparklineGraph9.ShowPoints = false;
            sparklineGraph9.ShowTooltips = false;
            sparklineGraph9.Size = new Size(203, 56);
            sparklineGraph9.SmoothLines = true;
            sparklineGraph9.TabIndex = 11;
            sparklineGraph9.ThresholdColor = Color.Red;
            // 
            // sparklineGraph10
            // 
            sparklineGraph10.BackColor = Color.Black;
            sparklineGraph10.GridColor = Color.LightGray;
            sparklineGraph10.LineColor = Color.ForestGreen;
            sparklineGraph10.Location = new Point(15, 278);
            sparklineGraph10.MaxDataPoints = 150;
            sparklineGraph10.Name = "sparklineGraph10";
            sparklineGraph10.PointColor = Color.Red;
            sparklineGraph10.ShowGrid = false;
            sparklineGraph10.ShowPoints = false;
            sparklineGraph10.ShowTooltips = false;
            sparklineGraph10.Size = new Size(203, 56);
            sparklineGraph10.SmoothLines = true;
            sparklineGraph10.TabIndex = 10;
            sparklineGraph10.ThresholdColor = Color.Red;
            sparklineGraph10.ThresholdValue = -1000F;
            // 
            // sparklineGraph11
            // 
            sparklineGraph11.BackColor = Color.Black;
            sparklineGraph11.GridColor = Color.LightGray;
            sparklineGraph11.LineColor = Color.ForestGreen;
            sparklineGraph11.Location = new Point(15, 712);
            sparklineGraph11.MaxDataPoints = 150;
            sparklineGraph11.Name = "sparklineGraph11";
            sparklineGraph11.PointColor = Color.Red;
            sparklineGraph11.ShowGrid = false;
            sparklineGraph11.ShowPoints = false;
            sparklineGraph11.ShowTooltips = false;
            sparklineGraph11.Size = new Size(203, 56);
            sparklineGraph11.SmoothLines = true;
            sparklineGraph11.TabIndex = 17;
            sparklineGraph11.ThresholdColor = Color.Red;
            // 
            // sparklineGraph12
            // 
            sparklineGraph12.BackColor = Color.Black;
            sparklineGraph12.GridColor = Color.LightGray;
            sparklineGraph12.LineColor = Color.ForestGreen;
            sparklineGraph12.Location = new Point(15, 650);
            sparklineGraph12.MaxDataPoints = 150;
            sparklineGraph12.Name = "sparklineGraph12";
            sparklineGraph12.PointColor = Color.Red;
            sparklineGraph12.ShowGrid = false;
            sparklineGraph12.ShowPoints = false;
            sparklineGraph12.ShowTooltips = false;
            sparklineGraph12.Size = new Size(203, 56);
            sparklineGraph12.SmoothLines = true;
            sparklineGraph12.TabIndex = 16;
            sparklineGraph12.ThresholdColor = Color.Red;
            // 
            // sparklineGraph13
            // 
            sparklineGraph13.BackColor = Color.Black;
            sparklineGraph13.GridColor = Color.LightGray;
            sparklineGraph13.LineColor = Color.ForestGreen;
            sparklineGraph13.Location = new Point(15, 588);
            sparklineGraph13.MaxDataPoints = 150;
            sparklineGraph13.Name = "sparklineGraph13";
            sparklineGraph13.PointColor = Color.Red;
            sparklineGraph13.ShowGrid = false;
            sparklineGraph13.ShowPoints = false;
            sparklineGraph13.ShowTooltips = false;
            sparklineGraph13.Size = new Size(203, 56);
            sparklineGraph13.SmoothLines = true;
            sparklineGraph13.TabIndex = 15;
            sparklineGraph13.ThresholdColor = Color.Red;
            // 
            // sparklineGraph14
            // 
            sparklineGraph14.BackColor = Color.Black;
            sparklineGraph14.GridColor = Color.LightGray;
            sparklineGraph14.LineColor = Color.ForestGreen;
            sparklineGraph14.Location = new Point(15, 526);
            sparklineGraph14.MaxDataPoints = 150;
            sparklineGraph14.Name = "sparklineGraph14";
            sparklineGraph14.PointColor = Color.Red;
            sparklineGraph14.ShowGrid = false;
            sparklineGraph14.ShowPoints = false;
            sparklineGraph14.ShowTooltips = false;
            sparklineGraph14.Size = new Size(203, 56);
            sparklineGraph14.SmoothLines = true;
            sparklineGraph14.TabIndex = 14;
            sparklineGraph14.ThresholdColor = Color.Red;
            sparklineGraph14.ThresholdValue = -1000F;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(sparklineGraph48);
            groupBox1.Controls.Add(sparklineGraph49);
            groupBox1.Controls.Add(sparklineGraph50);
            groupBox1.Controls.Add(sparklineGraph54);
            groupBox1.Controls.Add(sparklineGraph55);
            groupBox1.Controls.Add(sparklineGraph56);
            groupBox1.Controls.Add(sparklineGraph57);
            groupBox1.Controls.Add(sparklineGraph58);
            groupBox1.Controls.Add(sparklineGraph59);
            groupBox1.Controls.Add(sparklineGraph60);
            groupBox1.Controls.Add(sparklineGraph61);
            groupBox1.Controls.Add(sparklineGraph62);
            groupBox1.Controls.Add(sparklineGraph63);
            groupBox1.Controls.Add(sparklineGraph64);
            groupBox1.Controls.Add(sparklineGraph65);
            groupBox1.Controls.Add(sparklineGraph39);
            groupBox1.Controls.Add(sparklineGraph40);
            groupBox1.Controls.Add(sparklineGraph41);
            groupBox1.Controls.Add(sparklineGraph42);
            groupBox1.Controls.Add(sparklineGraph43);
            groupBox1.Controls.Add(sparklineGraph44);
            groupBox1.Controls.Add(sparklineGraph45);
            groupBox1.Controls.Add(sparklineGraph46);
            groupBox1.Controls.Add(sparklineGraph47);
            groupBox1.Controls.Add(sparklineGraph27);
            groupBox1.Controls.Add(sparklineGraph28);
            groupBox1.Controls.Add(sparklineGraph29);
            groupBox1.Controls.Add(sparklineGraph30);
            groupBox1.Controls.Add(sparklineGraph31);
            groupBox1.Controls.Add(sparklineGraph32);
            groupBox1.Controls.Add(sparklineGraph33);
            groupBox1.Controls.Add(sparklineGraph34);
            groupBox1.Controls.Add(sparklineGraph35);
            groupBox1.Controls.Add(sparklineGraph36);
            groupBox1.Controls.Add(sparklineGraph37);
            groupBox1.Controls.Add(sparklineGraph38);
            groupBox1.Controls.Add(sparklineGraph15);
            groupBox1.Controls.Add(sparklineGraph16);
            groupBox1.Controls.Add(sparklineGraph17);
            groupBox1.Controls.Add(sparklineGraph18);
            groupBox1.Controls.Add(sparklineGraph19);
            groupBox1.Controls.Add(sparklineGraph20);
            groupBox1.Controls.Add(sparklineGraph21);
            groupBox1.Controls.Add(sparklineGraph22);
            groupBox1.Controls.Add(sparklineGraph23);
            groupBox1.Controls.Add(sparklineGraph24);
            groupBox1.Controls.Add(sparklineGraph25);
            groupBox1.Controls.Add(sparklineGraph26);
            groupBox1.Controls.Add(sparklineGraph3);
            groupBox1.Controls.Add(sparklineGraph11);
            groupBox1.Controls.Add(sparklineGraph4);
            groupBox1.Controls.Add(sparklineGraph12);
            groupBox1.Controls.Add(sparklineGraph5);
            groupBox1.Controls.Add(sparklineGraph13);
            groupBox1.Controls.Add(sparklineGraph6);
            groupBox1.Controls.Add(sparklineGraph14);
            groupBox1.Controls.Add(sparklineGraph10);
            groupBox1.Controls.Add(sparklineGraph7);
            groupBox1.Controls.Add(sparklineGraph9);
            groupBox1.Controls.Add(sparklineGraph8);
            groupBox1.Location = new Point(1074, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1043, 975);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // sparklineGraph48
            // 
            sparklineGraph48.BackColor = Color.Black;
            sparklineGraph48.GridColor = Color.LightGray;
            sparklineGraph48.LineColor = Color.ForestGreen;
            sparklineGraph48.Location = new Point(642, 898);
            sparklineGraph48.MaxDataPoints = 150;
            sparklineGraph48.Name = "sparklineGraph48";
            sparklineGraph48.PointColor = Color.Red;
            sparklineGraph48.ShowGrid = false;
            sparklineGraph48.ShowPoints = false;
            sparklineGraph48.ShowTooltips = false;
            sparklineGraph48.Size = new Size(412, 56);
            sparklineGraph48.SmoothLines = true;
            sparklineGraph48.TabIndex = 80;
            sparklineGraph48.ThresholdColor = Color.Red;
            // 
            // sparklineGraph49
            // 
            sparklineGraph49.BackColor = Color.Black;
            sparklineGraph49.GridColor = Color.LightGray;
            sparklineGraph49.LineColor = Color.ForestGreen;
            sparklineGraph49.Location = new Point(642, 836);
            sparklineGraph49.MaxDataPoints = 150;
            sparklineGraph49.Name = "sparklineGraph49";
            sparklineGraph49.PointColor = Color.Red;
            sparklineGraph49.ShowGrid = false;
            sparklineGraph49.ShowPoints = false;
            sparklineGraph49.ShowTooltips = false;
            sparklineGraph49.Size = new Size(412, 56);
            sparklineGraph49.SmoothLines = true;
            sparklineGraph49.TabIndex = 79;
            sparklineGraph49.ThresholdColor = Color.Red;
            // 
            // sparklineGraph50
            // 
            sparklineGraph50.BackColor = Color.Black;
            sparklineGraph50.GridColor = Color.LightGray;
            sparklineGraph50.LineColor = Color.ForestGreen;
            sparklineGraph50.Location = new Point(642, 774);
            sparklineGraph50.MaxDataPoints = 150;
            sparklineGraph50.Name = "sparklineGraph50";
            sparklineGraph50.PointColor = Color.Red;
            sparklineGraph50.ShowGrid = false;
            sparklineGraph50.ShowPoints = false;
            sparklineGraph50.ShowTooltips = false;
            sparklineGraph50.Size = new Size(412, 56);
            sparklineGraph50.SmoothLines = true;
            sparklineGraph50.TabIndex = 78;
            sparklineGraph50.ThresholdColor = Color.Red;
            // 
            // sparklineGraph54
            // 
            sparklineGraph54.BackColor = Color.Black;
            sparklineGraph54.GridColor = Color.LightGray;
            sparklineGraph54.LineColor = Color.ForestGreen;
            sparklineGraph54.Location = new Point(642, 30);
            sparklineGraph54.MaxDataPoints = 150;
            sparklineGraph54.Name = "sparklineGraph54";
            sparklineGraph54.PointColor = Color.Red;
            sparklineGraph54.ShowGrid = false;
            sparklineGraph54.ShowPoints = false;
            sparklineGraph54.ShowTooltips = false;
            sparklineGraph54.Size = new Size(412, 56);
            sparklineGraph54.SmoothLines = true;
            sparklineGraph54.TabIndex = 63;
            sparklineGraph54.ThresholdColor = Color.Red;
            sparklineGraph54.ThresholdValue = -1000F;
            // 
            // sparklineGraph55
            // 
            sparklineGraph55.BackColor = Color.Black;
            sparklineGraph55.GridColor = Color.LightGray;
            sparklineGraph55.LineColor = Color.ForestGreen;
            sparklineGraph55.Location = new Point(642, 712);
            sparklineGraph55.MaxDataPoints = 150;
            sparklineGraph55.Name = "sparklineGraph55";
            sparklineGraph55.PointColor = Color.Red;
            sparklineGraph55.ShowGrid = false;
            sparklineGraph55.ShowPoints = false;
            sparklineGraph55.ShowTooltips = false;
            sparklineGraph55.Size = new Size(412, 56);
            sparklineGraph55.SmoothLines = true;
            sparklineGraph55.TabIndex = 74;
            sparklineGraph55.ThresholdColor = Color.Red;
            // 
            // sparklineGraph56
            // 
            sparklineGraph56.BackColor = Color.Black;
            sparklineGraph56.GridColor = Color.LightGray;
            sparklineGraph56.LineColor = Color.ForestGreen;
            sparklineGraph56.Location = new Point(642, 92);
            sparklineGraph56.MaxDataPoints = 150;
            sparklineGraph56.Name = "sparklineGraph56";
            sparklineGraph56.PointColor = Color.Red;
            sparklineGraph56.ShowGrid = false;
            sparklineGraph56.ShowPoints = false;
            sparklineGraph56.ShowTooltips = false;
            sparklineGraph56.Size = new Size(412, 56);
            sparklineGraph56.SmoothLines = true;
            sparklineGraph56.TabIndex = 64;
            sparklineGraph56.ThresholdColor = Color.Red;
            // 
            // sparklineGraph57
            // 
            sparklineGraph57.BackColor = Color.Black;
            sparklineGraph57.GridColor = Color.LightGray;
            sparklineGraph57.LineColor = Color.ForestGreen;
            sparklineGraph57.Location = new Point(642, 650);
            sparklineGraph57.MaxDataPoints = 150;
            sparklineGraph57.Name = "sparklineGraph57";
            sparklineGraph57.PointColor = Color.Red;
            sparklineGraph57.ShowGrid = false;
            sparklineGraph57.ShowPoints = false;
            sparklineGraph57.ShowTooltips = false;
            sparklineGraph57.Size = new Size(412, 56);
            sparklineGraph57.SmoothLines = true;
            sparklineGraph57.TabIndex = 73;
            sparklineGraph57.ThresholdColor = Color.Red;
            // 
            // sparklineGraph58
            // 
            sparklineGraph58.BackColor = Color.Black;
            sparklineGraph58.GridColor = Color.LightGray;
            sparklineGraph58.LineColor = Color.ForestGreen;
            sparklineGraph58.Location = new Point(642, 154);
            sparklineGraph58.MaxDataPoints = 150;
            sparklineGraph58.Name = "sparklineGraph58";
            sparklineGraph58.PointColor = Color.Red;
            sparklineGraph58.ShowGrid = false;
            sparklineGraph58.ShowPoints = false;
            sparklineGraph58.ShowTooltips = false;
            sparklineGraph58.Size = new Size(412, 56);
            sparklineGraph58.SmoothLines = true;
            sparklineGraph58.TabIndex = 65;
            sparklineGraph58.ThresholdColor = Color.Red;
            // 
            // sparklineGraph59
            // 
            sparklineGraph59.BackColor = Color.Black;
            sparklineGraph59.GridColor = Color.LightGray;
            sparklineGraph59.LineColor = Color.ForestGreen;
            sparklineGraph59.Location = new Point(642, 588);
            sparklineGraph59.MaxDataPoints = 150;
            sparklineGraph59.Name = "sparklineGraph59";
            sparklineGraph59.PointColor = Color.Red;
            sparklineGraph59.ShowGrid = false;
            sparklineGraph59.ShowPoints = false;
            sparklineGraph59.ShowTooltips = false;
            sparklineGraph59.Size = new Size(412, 56);
            sparklineGraph59.SmoothLines = true;
            sparklineGraph59.TabIndex = 72;
            sparklineGraph59.ThresholdColor = Color.Red;
            // 
            // sparklineGraph60
            // 
            sparklineGraph60.BackColor = Color.Black;
            sparklineGraph60.GridColor = Color.LightGray;
            sparklineGraph60.LineColor = Color.ForestGreen;
            sparklineGraph60.Location = new Point(642, 216);
            sparklineGraph60.MaxDataPoints = 150;
            sparklineGraph60.Name = "sparklineGraph60";
            sparklineGraph60.PointColor = Color.Red;
            sparklineGraph60.ShowGrid = false;
            sparklineGraph60.ShowPoints = false;
            sparklineGraph60.ShowTooltips = false;
            sparklineGraph60.Size = new Size(412, 56);
            sparklineGraph60.SmoothLines = true;
            sparklineGraph60.TabIndex = 66;
            sparklineGraph60.ThresholdColor = Color.Red;
            // 
            // sparklineGraph61
            // 
            sparklineGraph61.BackColor = Color.Black;
            sparklineGraph61.GridColor = Color.LightGray;
            sparklineGraph61.LineColor = Color.ForestGreen;
            sparklineGraph61.Location = new Point(642, 526);
            sparklineGraph61.MaxDataPoints = 150;
            sparklineGraph61.Name = "sparklineGraph61";
            sparklineGraph61.PointColor = Color.Red;
            sparklineGraph61.ShowGrid = false;
            sparklineGraph61.ShowPoints = false;
            sparklineGraph61.ShowTooltips = false;
            sparklineGraph61.Size = new Size(412, 56);
            sparklineGraph61.SmoothLines = true;
            sparklineGraph61.TabIndex = 71;
            sparklineGraph61.ThresholdColor = Color.Red;
            sparklineGraph61.ThresholdValue = -1000F;
            // 
            // sparklineGraph62
            // 
            sparklineGraph62.BackColor = Color.Black;
            sparklineGraph62.GridColor = Color.LightGray;
            sparklineGraph62.LineColor = Color.ForestGreen;
            sparklineGraph62.Location = new Point(642, 278);
            sparklineGraph62.MaxDataPoints = 150;
            sparklineGraph62.Name = "sparklineGraph62";
            sparklineGraph62.PointColor = Color.Red;
            sparklineGraph62.ShowGrid = false;
            sparklineGraph62.ShowPoints = false;
            sparklineGraph62.ShowTooltips = false;
            sparklineGraph62.Size = new Size(412, 56);
            sparklineGraph62.SmoothLines = true;
            sparklineGraph62.TabIndex = 67;
            sparklineGraph62.ThresholdColor = Color.Red;
            sparklineGraph62.ThresholdValue = -1000F;
            // 
            // sparklineGraph63
            // 
            sparklineGraph63.BackColor = Color.Black;
            sparklineGraph63.GridColor = Color.LightGray;
            sparklineGraph63.LineColor = Color.ForestGreen;
            sparklineGraph63.Location = new Point(642, 464);
            sparklineGraph63.MaxDataPoints = 150;
            sparklineGraph63.Name = "sparklineGraph63";
            sparklineGraph63.PointColor = Color.Red;
            sparklineGraph63.ShowGrid = false;
            sparklineGraph63.ShowPoints = false;
            sparklineGraph63.ShowTooltips = false;
            sparklineGraph63.Size = new Size(412, 56);
            sparklineGraph63.SmoothLines = true;
            sparklineGraph63.TabIndex = 70;
            sparklineGraph63.ThresholdColor = Color.Red;
            // 
            // sparklineGraph64
            // 
            sparklineGraph64.BackColor = Color.Black;
            sparklineGraph64.GridColor = Color.LightGray;
            sparklineGraph64.LineColor = Color.ForestGreen;
            sparklineGraph64.Location = new Point(642, 340);
            sparklineGraph64.MaxDataPoints = 150;
            sparklineGraph64.Name = "sparklineGraph64";
            sparklineGraph64.PointColor = Color.Red;
            sparklineGraph64.ShowGrid = false;
            sparklineGraph64.ShowPoints = false;
            sparklineGraph64.ShowTooltips = false;
            sparklineGraph64.Size = new Size(412, 56);
            sparklineGraph64.SmoothLines = true;
            sparklineGraph64.TabIndex = 68;
            sparklineGraph64.ThresholdColor = Color.Red;
            // 
            // sparklineGraph65
            // 
            sparklineGraph65.BackColor = Color.Black;
            sparklineGraph65.GridColor = Color.LightGray;
            sparklineGraph65.LineColor = Color.ForestGreen;
            sparklineGraph65.Location = new Point(642, 402);
            sparklineGraph65.MaxDataPoints = 150;
            sparklineGraph65.Name = "sparklineGraph65";
            sparklineGraph65.PointColor = Color.Red;
            sparklineGraph65.ShowGrid = false;
            sparklineGraph65.ShowPoints = false;
            sparklineGraph65.ShowTooltips = false;
            sparklineGraph65.Size = new Size(412, 56);
            sparklineGraph65.SmoothLines = true;
            sparklineGraph65.TabIndex = 69;
            sparklineGraph65.ThresholdColor = Color.Red;
            // 
            // sparklineGraph39
            // 
            sparklineGraph39.BackColor = Color.Black;
            sparklineGraph39.GridColor = Color.LightGray;
            sparklineGraph39.LineColor = Color.ForestGreen;
            sparklineGraph39.Location = new Point(433, 898);
            sparklineGraph39.MaxDataPoints = 150;
            sparklineGraph39.Name = "sparklineGraph39";
            sparklineGraph39.PointColor = Color.Red;
            sparklineGraph39.ShowGrid = false;
            sparklineGraph39.ShowPoints = false;
            sparklineGraph39.ShowTooltips = false;
            sparklineGraph39.Size = new Size(203, 56);
            sparklineGraph39.SmoothLines = true;
            sparklineGraph39.TabIndex = 50;
            sparklineGraph39.ThresholdColor = Color.Red;
            // 
            // sparklineGraph40
            // 
            sparklineGraph40.BackColor = Color.Black;
            sparklineGraph40.GridColor = Color.LightGray;
            sparklineGraph40.LineColor = Color.ForestGreen;
            sparklineGraph40.Location = new Point(433, 836);
            sparklineGraph40.MaxDataPoints = 150;
            sparklineGraph40.Name = "sparklineGraph40";
            sparklineGraph40.PointColor = Color.Red;
            sparklineGraph40.ShowGrid = false;
            sparklineGraph40.ShowPoints = false;
            sparklineGraph40.ShowTooltips = false;
            sparklineGraph40.Size = new Size(203, 56);
            sparklineGraph40.SmoothLines = true;
            sparklineGraph40.TabIndex = 49;
            sparklineGraph40.ThresholdColor = Color.Red;
            // 
            // sparklineGraph41
            // 
            sparklineGraph41.BackColor = Color.Black;
            sparklineGraph41.GridColor = Color.LightGray;
            sparklineGraph41.LineColor = Color.ForestGreen;
            sparklineGraph41.Location = new Point(433, 774);
            sparklineGraph41.MaxDataPoints = 150;
            sparklineGraph41.Name = "sparklineGraph41";
            sparklineGraph41.PointColor = Color.Red;
            sparklineGraph41.ShowGrid = false;
            sparklineGraph41.ShowPoints = false;
            sparklineGraph41.ShowTooltips = false;
            sparklineGraph41.Size = new Size(203, 56);
            sparklineGraph41.SmoothLines = true;
            sparklineGraph41.TabIndex = 48;
            sparklineGraph41.ThresholdColor = Color.Red;
            // 
            // sparklineGraph42
            // 
            sparklineGraph42.BackColor = Color.Black;
            sparklineGraph42.GridColor = Color.LightGray;
            sparklineGraph42.LineColor = Color.ForestGreen;
            sparklineGraph42.Location = new Point(224, 898);
            sparklineGraph42.MaxDataPoints = 150;
            sparklineGraph42.Name = "sparklineGraph42";
            sparklineGraph42.PointColor = Color.Red;
            sparklineGraph42.ShowGrid = false;
            sparklineGraph42.ShowPoints = false;
            sparklineGraph42.ShowTooltips = false;
            sparklineGraph42.Size = new Size(203, 56);
            sparklineGraph42.SmoothLines = true;
            sparklineGraph42.TabIndex = 47;
            sparklineGraph42.ThresholdColor = Color.Red;
            // 
            // sparklineGraph43
            // 
            sparklineGraph43.BackColor = Color.Black;
            sparklineGraph43.GridColor = Color.LightGray;
            sparklineGraph43.LineColor = Color.ForestGreen;
            sparklineGraph43.Location = new Point(224, 836);
            sparklineGraph43.MaxDataPoints = 150;
            sparklineGraph43.Name = "sparklineGraph43";
            sparklineGraph43.PointColor = Color.Red;
            sparklineGraph43.ShowGrid = false;
            sparklineGraph43.ShowPoints = false;
            sparklineGraph43.ShowTooltips = false;
            sparklineGraph43.Size = new Size(203, 56);
            sparklineGraph43.SmoothLines = true;
            sparklineGraph43.TabIndex = 46;
            sparklineGraph43.ThresholdColor = Color.Red;
            // 
            // sparklineGraph44
            // 
            sparklineGraph44.BackColor = Color.Black;
            sparklineGraph44.GridColor = Color.LightGray;
            sparklineGraph44.LineColor = Color.ForestGreen;
            sparklineGraph44.Location = new Point(224, 774);
            sparklineGraph44.MaxDataPoints = 150;
            sparklineGraph44.Name = "sparklineGraph44";
            sparklineGraph44.PointColor = Color.Red;
            sparklineGraph44.ShowGrid = false;
            sparklineGraph44.ShowPoints = false;
            sparklineGraph44.ShowTooltips = false;
            sparklineGraph44.Size = new Size(203, 56);
            sparklineGraph44.SmoothLines = true;
            sparklineGraph44.TabIndex = 45;
            sparklineGraph44.ThresholdColor = Color.Red;
            // 
            // sparklineGraph45
            // 
            sparklineGraph45.BackColor = Color.Black;
            sparklineGraph45.GridColor = Color.LightGray;
            sparklineGraph45.LineColor = Color.ForestGreen;
            sparklineGraph45.Location = new Point(15, 898);
            sparklineGraph45.MaxDataPoints = 150;
            sparklineGraph45.Name = "sparklineGraph45";
            sparklineGraph45.PointColor = Color.Red;
            sparklineGraph45.ShowGrid = false;
            sparklineGraph45.ShowPoints = false;
            sparklineGraph45.ShowTooltips = false;
            sparklineGraph45.Size = new Size(203, 56);
            sparklineGraph45.SmoothLines = true;
            sparklineGraph45.TabIndex = 44;
            sparklineGraph45.ThresholdColor = Color.Red;
            // 
            // sparklineGraph46
            // 
            sparklineGraph46.BackColor = Color.Black;
            sparklineGraph46.GridColor = Color.LightGray;
            sparklineGraph46.LineColor = Color.ForestGreen;
            sparklineGraph46.Location = new Point(15, 836);
            sparklineGraph46.MaxDataPoints = 150;
            sparklineGraph46.Name = "sparklineGraph46";
            sparklineGraph46.PointColor = Color.Red;
            sparklineGraph46.ShowGrid = false;
            sparklineGraph46.ShowPoints = false;
            sparklineGraph46.ShowTooltips = false;
            sparklineGraph46.Size = new Size(203, 56);
            sparklineGraph46.SmoothLines = true;
            sparklineGraph46.TabIndex = 43;
            sparklineGraph46.ThresholdColor = Color.Red;
            // 
            // sparklineGraph47
            // 
            sparklineGraph47.BackColor = Color.Black;
            sparklineGraph47.GridColor = Color.LightGray;
            sparklineGraph47.LineColor = Color.ForestGreen;
            sparklineGraph47.Location = new Point(15, 774);
            sparklineGraph47.MaxDataPoints = 150;
            sparklineGraph47.Name = "sparklineGraph47";
            sparklineGraph47.PointColor = Color.Red;
            sparklineGraph47.ShowGrid = false;
            sparklineGraph47.ShowPoints = false;
            sparklineGraph47.ShowTooltips = false;
            sparklineGraph47.Size = new Size(203, 56);
            sparklineGraph47.SmoothLines = true;
            sparklineGraph47.TabIndex = 42;
            sparklineGraph47.ThresholdColor = Color.Red;
            // 
            // sparklineGraph27
            // 
            sparklineGraph27.BackColor = Color.Black;
            sparklineGraph27.GridColor = Color.LightGray;
            sparklineGraph27.LineColor = Color.ForestGreen;
            sparklineGraph27.Location = new Point(433, 30);
            sparklineGraph27.MaxDataPoints = 150;
            sparklineGraph27.Name = "sparklineGraph27";
            sparklineGraph27.PointColor = Color.Red;
            sparklineGraph27.ShowGrid = false;
            sparklineGraph27.ShowPoints = false;
            sparklineGraph27.ShowTooltips = false;
            sparklineGraph27.Size = new Size(203, 56);
            sparklineGraph27.SmoothLines = true;
            sparklineGraph27.TabIndex = 30;
            sparklineGraph27.ThresholdColor = Color.Red;
            sparklineGraph27.ThresholdValue = -1000F;
            // 
            // sparklineGraph28
            // 
            sparklineGraph28.BackColor = Color.Black;
            sparklineGraph28.GridColor = Color.LightGray;
            sparklineGraph28.LineColor = Color.ForestGreen;
            sparklineGraph28.Location = new Point(433, 712);
            sparklineGraph28.MaxDataPoints = 150;
            sparklineGraph28.Name = "sparklineGraph28";
            sparklineGraph28.PointColor = Color.Red;
            sparklineGraph28.ShowGrid = false;
            sparklineGraph28.ShowPoints = false;
            sparklineGraph28.ShowTooltips = false;
            sparklineGraph28.Size = new Size(203, 56);
            sparklineGraph28.SmoothLines = true;
            sparklineGraph28.TabIndex = 41;
            sparklineGraph28.ThresholdColor = Color.Red;
            // 
            // sparklineGraph29
            // 
            sparklineGraph29.BackColor = Color.Black;
            sparklineGraph29.GridColor = Color.LightGray;
            sparklineGraph29.LineColor = Color.ForestGreen;
            sparklineGraph29.Location = new Point(433, 92);
            sparklineGraph29.MaxDataPoints = 150;
            sparklineGraph29.Name = "sparklineGraph29";
            sparklineGraph29.PointColor = Color.Red;
            sparklineGraph29.ShowGrid = false;
            sparklineGraph29.ShowPoints = false;
            sparklineGraph29.ShowTooltips = false;
            sparklineGraph29.Size = new Size(203, 56);
            sparklineGraph29.SmoothLines = true;
            sparklineGraph29.TabIndex = 31;
            sparklineGraph29.ThresholdColor = Color.Red;
            // 
            // sparklineGraph30
            // 
            sparklineGraph30.BackColor = Color.Black;
            sparklineGraph30.GridColor = Color.LightGray;
            sparklineGraph30.LineColor = Color.ForestGreen;
            sparklineGraph30.Location = new Point(433, 650);
            sparklineGraph30.MaxDataPoints = 150;
            sparklineGraph30.Name = "sparklineGraph30";
            sparklineGraph30.PointColor = Color.Red;
            sparklineGraph30.ShowGrid = false;
            sparklineGraph30.ShowPoints = false;
            sparklineGraph30.ShowTooltips = false;
            sparklineGraph30.Size = new Size(203, 56);
            sparklineGraph30.SmoothLines = true;
            sparklineGraph30.TabIndex = 40;
            sparklineGraph30.ThresholdColor = Color.Red;
            // 
            // sparklineGraph31
            // 
            sparklineGraph31.BackColor = Color.Black;
            sparklineGraph31.GridColor = Color.LightGray;
            sparklineGraph31.LineColor = Color.ForestGreen;
            sparklineGraph31.Location = new Point(433, 154);
            sparklineGraph31.MaxDataPoints = 150;
            sparklineGraph31.Name = "sparklineGraph31";
            sparklineGraph31.PointColor = Color.Red;
            sparklineGraph31.ShowGrid = false;
            sparklineGraph31.ShowPoints = false;
            sparklineGraph31.ShowTooltips = false;
            sparklineGraph31.Size = new Size(203, 56);
            sparklineGraph31.SmoothLines = true;
            sparklineGraph31.TabIndex = 32;
            sparklineGraph31.ThresholdColor = Color.Red;
            // 
            // sparklineGraph32
            // 
            sparklineGraph32.BackColor = Color.Black;
            sparklineGraph32.GridColor = Color.LightGray;
            sparklineGraph32.LineColor = Color.ForestGreen;
            sparklineGraph32.Location = new Point(433, 588);
            sparklineGraph32.MaxDataPoints = 150;
            sparklineGraph32.Name = "sparklineGraph32";
            sparklineGraph32.PointColor = Color.Red;
            sparklineGraph32.ShowGrid = false;
            sparklineGraph32.ShowPoints = false;
            sparklineGraph32.ShowTooltips = false;
            sparklineGraph32.Size = new Size(203, 56);
            sparklineGraph32.SmoothLines = true;
            sparklineGraph32.TabIndex = 39;
            sparklineGraph32.ThresholdColor = Color.Red;
            // 
            // sparklineGraph33
            // 
            sparklineGraph33.BackColor = Color.Black;
            sparklineGraph33.GridColor = Color.LightGray;
            sparklineGraph33.LineColor = Color.ForestGreen;
            sparklineGraph33.Location = new Point(433, 216);
            sparklineGraph33.MaxDataPoints = 150;
            sparklineGraph33.Name = "sparklineGraph33";
            sparklineGraph33.PointColor = Color.Red;
            sparklineGraph33.ShowGrid = false;
            sparklineGraph33.ShowPoints = false;
            sparklineGraph33.ShowTooltips = false;
            sparklineGraph33.Size = new Size(203, 56);
            sparklineGraph33.SmoothLines = true;
            sparklineGraph33.TabIndex = 33;
            sparklineGraph33.ThresholdColor = Color.Red;
            // 
            // sparklineGraph34
            // 
            sparklineGraph34.BackColor = Color.Black;
            sparklineGraph34.GridColor = Color.LightGray;
            sparklineGraph34.LineColor = Color.ForestGreen;
            sparklineGraph34.Location = new Point(433, 526);
            sparklineGraph34.MaxDataPoints = 150;
            sparklineGraph34.Name = "sparklineGraph34";
            sparklineGraph34.PointColor = Color.Red;
            sparklineGraph34.ShowGrid = false;
            sparklineGraph34.ShowPoints = false;
            sparklineGraph34.ShowTooltips = false;
            sparklineGraph34.Size = new Size(203, 56);
            sparklineGraph34.SmoothLines = true;
            sparklineGraph34.TabIndex = 38;
            sparklineGraph34.ThresholdColor = Color.Red;
            sparklineGraph34.ThresholdValue = -1000F;
            // 
            // sparklineGraph35
            // 
            sparklineGraph35.BackColor = Color.Black;
            sparklineGraph35.GridColor = Color.LightGray;
            sparklineGraph35.LineColor = Color.ForestGreen;
            sparklineGraph35.Location = new Point(433, 278);
            sparklineGraph35.MaxDataPoints = 150;
            sparklineGraph35.Name = "sparklineGraph35";
            sparklineGraph35.PointColor = Color.Red;
            sparklineGraph35.ShowGrid = false;
            sparklineGraph35.ShowPoints = false;
            sparklineGraph35.ShowTooltips = false;
            sparklineGraph35.Size = new Size(203, 56);
            sparklineGraph35.SmoothLines = true;
            sparklineGraph35.TabIndex = 34;
            sparklineGraph35.ThresholdColor = Color.Red;
            sparklineGraph35.ThresholdValue = -1000F;
            // 
            // sparklineGraph36
            // 
            sparklineGraph36.BackColor = Color.Black;
            sparklineGraph36.GridColor = Color.LightGray;
            sparklineGraph36.LineColor = Color.ForestGreen;
            sparklineGraph36.Location = new Point(433, 464);
            sparklineGraph36.MaxDataPoints = 150;
            sparklineGraph36.Name = "sparklineGraph36";
            sparklineGraph36.PointColor = Color.Red;
            sparklineGraph36.ShowGrid = false;
            sparklineGraph36.ShowPoints = false;
            sparklineGraph36.ShowTooltips = false;
            sparklineGraph36.Size = new Size(203, 56);
            sparklineGraph36.SmoothLines = true;
            sparklineGraph36.TabIndex = 37;
            sparklineGraph36.ThresholdColor = Color.Red;
            // 
            // sparklineGraph37
            // 
            sparklineGraph37.BackColor = Color.Black;
            sparklineGraph37.GridColor = Color.LightGray;
            sparklineGraph37.LineColor = Color.ForestGreen;
            sparklineGraph37.Location = new Point(433, 340);
            sparklineGraph37.MaxDataPoints = 150;
            sparklineGraph37.Name = "sparklineGraph37";
            sparklineGraph37.PointColor = Color.Red;
            sparklineGraph37.ShowGrid = false;
            sparklineGraph37.ShowPoints = false;
            sparklineGraph37.ShowTooltips = false;
            sparklineGraph37.Size = new Size(203, 56);
            sparklineGraph37.SmoothLines = true;
            sparklineGraph37.TabIndex = 35;
            sparklineGraph37.ThresholdColor = Color.Red;
            // 
            // sparklineGraph38
            // 
            sparklineGraph38.BackColor = Color.Black;
            sparklineGraph38.GridColor = Color.LightGray;
            sparklineGraph38.LineColor = Color.ForestGreen;
            sparklineGraph38.Location = new Point(433, 402);
            sparklineGraph38.MaxDataPoints = 150;
            sparklineGraph38.Name = "sparklineGraph38";
            sparklineGraph38.PointColor = Color.Red;
            sparklineGraph38.ShowGrid = false;
            sparklineGraph38.ShowPoints = false;
            sparklineGraph38.ShowTooltips = false;
            sparklineGraph38.Size = new Size(203, 56);
            sparklineGraph38.SmoothLines = true;
            sparklineGraph38.TabIndex = 36;
            sparklineGraph38.ThresholdColor = Color.Red;
            // 
            // sparklineGraph15
            // 
            sparklineGraph15.BackColor = Color.Black;
            sparklineGraph15.GridColor = Color.LightGray;
            sparklineGraph15.LineColor = Color.ForestGreen;
            sparklineGraph15.Location = new Point(224, 30);
            sparklineGraph15.MaxDataPoints = 150;
            sparklineGraph15.Name = "sparklineGraph15";
            sparklineGraph15.PointColor = Color.Red;
            sparklineGraph15.ShowGrid = false;
            sparklineGraph15.ShowPoints = false;
            sparklineGraph15.ShowTooltips = false;
            sparklineGraph15.Size = new Size(203, 56);
            sparklineGraph15.SmoothLines = true;
            sparklineGraph15.TabIndex = 18;
            sparklineGraph15.ThresholdColor = Color.Red;
            sparklineGraph15.ThresholdValue = -1000F;
            // 
            // sparklineGraph16
            // 
            sparklineGraph16.BackColor = Color.Black;
            sparklineGraph16.GridColor = Color.LightGray;
            sparklineGraph16.LineColor = Color.ForestGreen;
            sparklineGraph16.Location = new Point(224, 712);
            sparklineGraph16.MaxDataPoints = 150;
            sparklineGraph16.Name = "sparklineGraph16";
            sparklineGraph16.PointColor = Color.Red;
            sparklineGraph16.ShowGrid = false;
            sparklineGraph16.ShowPoints = false;
            sparklineGraph16.ShowTooltips = false;
            sparklineGraph16.Size = new Size(203, 56);
            sparklineGraph16.SmoothLines = true;
            sparklineGraph16.TabIndex = 29;
            sparklineGraph16.ThresholdColor = Color.Red;
            // 
            // sparklineGraph17
            // 
            sparklineGraph17.BackColor = Color.Black;
            sparklineGraph17.GridColor = Color.LightGray;
            sparklineGraph17.LineColor = Color.ForestGreen;
            sparklineGraph17.Location = new Point(224, 92);
            sparklineGraph17.MaxDataPoints = 150;
            sparklineGraph17.Name = "sparklineGraph17";
            sparklineGraph17.PointColor = Color.Red;
            sparklineGraph17.ShowGrid = false;
            sparklineGraph17.ShowPoints = false;
            sparklineGraph17.ShowTooltips = false;
            sparklineGraph17.Size = new Size(203, 56);
            sparklineGraph17.SmoothLines = true;
            sparklineGraph17.TabIndex = 19;
            sparklineGraph17.ThresholdColor = Color.Red;
            // 
            // sparklineGraph18
            // 
            sparklineGraph18.BackColor = Color.Black;
            sparklineGraph18.GridColor = Color.LightGray;
            sparklineGraph18.LineColor = Color.ForestGreen;
            sparklineGraph18.Location = new Point(224, 650);
            sparklineGraph18.MaxDataPoints = 150;
            sparklineGraph18.Name = "sparklineGraph18";
            sparklineGraph18.PointColor = Color.Red;
            sparklineGraph18.ShowGrid = false;
            sparklineGraph18.ShowPoints = false;
            sparklineGraph18.ShowTooltips = false;
            sparklineGraph18.Size = new Size(203, 56);
            sparklineGraph18.SmoothLines = true;
            sparklineGraph18.TabIndex = 28;
            sparklineGraph18.ThresholdColor = Color.Red;
            // 
            // sparklineGraph19
            // 
            sparklineGraph19.BackColor = Color.Black;
            sparklineGraph19.GridColor = Color.LightGray;
            sparklineGraph19.LineColor = Color.ForestGreen;
            sparklineGraph19.Location = new Point(224, 154);
            sparklineGraph19.MaxDataPoints = 150;
            sparklineGraph19.Name = "sparklineGraph19";
            sparklineGraph19.PointColor = Color.Red;
            sparklineGraph19.ShowGrid = false;
            sparklineGraph19.ShowPoints = false;
            sparklineGraph19.ShowTooltips = false;
            sparklineGraph19.Size = new Size(203, 56);
            sparklineGraph19.SmoothLines = true;
            sparklineGraph19.TabIndex = 20;
            sparklineGraph19.ThresholdColor = Color.Red;
            // 
            // sparklineGraph20
            // 
            sparklineGraph20.BackColor = Color.Black;
            sparklineGraph20.GridColor = Color.LightGray;
            sparklineGraph20.LineColor = Color.ForestGreen;
            sparklineGraph20.Location = new Point(224, 588);
            sparklineGraph20.MaxDataPoints = 150;
            sparklineGraph20.Name = "sparklineGraph20";
            sparklineGraph20.PointColor = Color.Red;
            sparklineGraph20.ShowGrid = false;
            sparklineGraph20.ShowPoints = false;
            sparklineGraph20.ShowTooltips = false;
            sparklineGraph20.Size = new Size(203, 56);
            sparklineGraph20.SmoothLines = true;
            sparklineGraph20.TabIndex = 27;
            sparklineGraph20.ThresholdColor = Color.Red;
            // 
            // sparklineGraph21
            // 
            sparklineGraph21.BackColor = Color.Black;
            sparklineGraph21.GridColor = Color.LightGray;
            sparklineGraph21.LineColor = Color.ForestGreen;
            sparklineGraph21.Location = new Point(224, 216);
            sparklineGraph21.MaxDataPoints = 150;
            sparklineGraph21.Name = "sparklineGraph21";
            sparklineGraph21.PointColor = Color.Red;
            sparklineGraph21.ShowGrid = false;
            sparklineGraph21.ShowPoints = false;
            sparklineGraph21.ShowTooltips = false;
            sparklineGraph21.Size = new Size(203, 56);
            sparklineGraph21.SmoothLines = true;
            sparklineGraph21.TabIndex = 21;
            sparklineGraph21.ThresholdColor = Color.Red;
            // 
            // sparklineGraph22
            // 
            sparklineGraph22.BackColor = Color.Black;
            sparklineGraph22.GridColor = Color.LightGray;
            sparklineGraph22.LineColor = Color.ForestGreen;
            sparklineGraph22.Location = new Point(224, 526);
            sparklineGraph22.MaxDataPoints = 150;
            sparklineGraph22.Name = "sparklineGraph22";
            sparklineGraph22.PointColor = Color.Red;
            sparklineGraph22.ShowGrid = false;
            sparklineGraph22.ShowPoints = false;
            sparklineGraph22.ShowTooltips = false;
            sparklineGraph22.Size = new Size(203, 56);
            sparklineGraph22.SmoothLines = true;
            sparklineGraph22.TabIndex = 26;
            sparklineGraph22.ThresholdColor = Color.Red;
            sparklineGraph22.ThresholdValue = -1000F;
            // 
            // sparklineGraph23
            // 
            sparklineGraph23.BackColor = Color.Black;
            sparklineGraph23.GridColor = Color.LightGray;
            sparklineGraph23.LineColor = Color.ForestGreen;
            sparklineGraph23.Location = new Point(224, 278);
            sparklineGraph23.MaxDataPoints = 150;
            sparklineGraph23.Name = "sparklineGraph23";
            sparklineGraph23.PointColor = Color.Red;
            sparklineGraph23.ShowGrid = false;
            sparklineGraph23.ShowPoints = false;
            sparklineGraph23.ShowTooltips = false;
            sparklineGraph23.Size = new Size(203, 56);
            sparklineGraph23.SmoothLines = true;
            sparklineGraph23.TabIndex = 22;
            sparklineGraph23.ThresholdColor = Color.Red;
            sparklineGraph23.ThresholdValue = -1000F;
            // 
            // sparklineGraph24
            // 
            sparklineGraph24.BackColor = Color.Black;
            sparklineGraph24.GridColor = Color.LightGray;
            sparklineGraph24.LineColor = Color.ForestGreen;
            sparklineGraph24.Location = new Point(224, 464);
            sparklineGraph24.MaxDataPoints = 150;
            sparklineGraph24.Name = "sparklineGraph24";
            sparklineGraph24.PointColor = Color.Red;
            sparklineGraph24.ShowGrid = false;
            sparklineGraph24.ShowPoints = false;
            sparklineGraph24.ShowTooltips = false;
            sparklineGraph24.Size = new Size(203, 56);
            sparklineGraph24.SmoothLines = true;
            sparklineGraph24.TabIndex = 25;
            sparklineGraph24.ThresholdColor = Color.Red;
            // 
            // sparklineGraph25
            // 
            sparklineGraph25.BackColor = Color.Black;
            sparklineGraph25.GridColor = Color.LightGray;
            sparklineGraph25.LineColor = Color.ForestGreen;
            sparklineGraph25.Location = new Point(224, 340);
            sparklineGraph25.MaxDataPoints = 150;
            sparklineGraph25.Name = "sparklineGraph25";
            sparklineGraph25.PointColor = Color.Red;
            sparklineGraph25.ShowGrid = false;
            sparklineGraph25.ShowPoints = false;
            sparklineGraph25.ShowTooltips = false;
            sparklineGraph25.Size = new Size(203, 56);
            sparklineGraph25.SmoothLines = true;
            sparklineGraph25.TabIndex = 23;
            sparklineGraph25.ThresholdColor = Color.Red;
            // 
            // sparklineGraph26
            // 
            sparklineGraph26.BackColor = Color.Black;
            sparklineGraph26.GridColor = Color.LightGray;
            sparklineGraph26.LineColor = Color.ForestGreen;
            sparklineGraph26.Location = new Point(224, 402);
            sparklineGraph26.MaxDataPoints = 150;
            sparklineGraph26.Name = "sparklineGraph26";
            sparklineGraph26.PointColor = Color.Red;
            sparklineGraph26.ShowGrid = false;
            sparklineGraph26.ShowPoints = false;
            sparklineGraph26.ShowTooltips = false;
            sparklineGraph26.Size = new Size(203, 56);
            sparklineGraph26.SmoothLines = true;
            sparklineGraph26.TabIndex = 24;
            sparklineGraph26.ThresholdColor = Color.Red;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2158, 1024);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SparklineGraph sparklineGraph1;
        private SparklineGraph sparklineGraph2;
        private SparklineGraphController sparklineGraphController1;
        private SparklineGraphController sparklineGraphController2;
        private Panel panel1;
        private Panel panel2;
        private SparklineGraph sparklineGraph3;
        private SparklineGraph sparklineGraph4;
        private SparklineGraph sparklineGraph5;
        private SparklineGraph sparklineGraph6;
        private SparklineGraph sparklineGraph7;
        private SparklineGraph sparklineGraph8;
        private SparklineGraph sparklineGraph9;
        private SparklineGraph sparklineGraph10;
        private SparklineGraph sparklineGraph11;
        private SparklineGraph sparklineGraph12;
        private SparklineGraph sparklineGraph13;
        private SparklineGraph sparklineGraph14;
        private GroupBox groupBox1;
        private SparklineGraph sparklineGraph39;
        private SparklineGraph sparklineGraph40;
        private SparklineGraph sparklineGraph41;
        private SparklineGraph sparklineGraph42;
        private SparklineGraph sparklineGraph43;
        private SparklineGraph sparklineGraph44;
        private SparklineGraph sparklineGraph45;
        private SparklineGraph sparklineGraph46;
        private SparklineGraph sparklineGraph47;
        private SparklineGraph sparklineGraph27;
        private SparklineGraph sparklineGraph28;
        private SparklineGraph sparklineGraph29;
        private SparklineGraph sparklineGraph30;
        private SparklineGraph sparklineGraph31;
        private SparklineGraph sparklineGraph32;
        private SparklineGraph sparklineGraph33;
        private SparklineGraph sparklineGraph34;
        private SparklineGraph sparklineGraph35;
        private SparklineGraph sparklineGraph36;
        private SparklineGraph sparklineGraph37;
        private SparklineGraph sparklineGraph38;
        private SparklineGraph sparklineGraph15;
        private SparklineGraph sparklineGraph16;
        private SparklineGraph sparklineGraph17;
        private SparklineGraph sparklineGraph18;
        private SparklineGraph sparklineGraph19;
        private SparklineGraph sparklineGraph20;
        private SparklineGraph sparklineGraph21;
        private SparklineGraph sparklineGraph22;
        private SparklineGraph sparklineGraph23;
        private SparklineGraph sparklineGraph24;
        private SparklineGraph sparklineGraph25;
        private SparklineGraph sparklineGraph26;
        private SparklineGraph sparklineGraph48;
        private SparklineGraph sparklineGraph49;
        private SparklineGraph sparklineGraph50;
        private SparklineGraph sparklineGraph54;
        private SparklineGraph sparklineGraph55;
        private SparklineGraph sparklineGraph56;
        private SparklineGraph sparklineGraph57;
        private SparklineGraph sparklineGraph58;
        private SparklineGraph sparklineGraph59;
        private SparklineGraph sparklineGraph60;
        private SparklineGraph sparklineGraph61;
        private SparklineGraph sparklineGraph62;
        private SparklineGraph sparklineGraph63;
        private SparklineGraph sparklineGraph64;
        private SparklineGraph sparklineGraph65;
    }
}
