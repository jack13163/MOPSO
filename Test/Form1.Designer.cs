namespace Test
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tChart1 = new Steema.TeeChart.TChart();
            this.points1 = new Steema.TeeChart.Styles.Points();
            this.chartLayout1 = new Steema.TeeChart.Components.ChartLayout();
            this.points2 = new Steema.TeeChart.Styles.Points();
            this.chartLayout1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ColorPaletteIndex = 20;
            this.tChart1.Aspect.View3D = false;
            // 
            // 
            // 
            this.tChart1.Axes.Automatic = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Grid.DrawEvery = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tChart1.Axes.Bottom.Labels.Font.Size = 9;
            this.tChart1.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Bottom.Title.Font.Size = 11;
            this.tChart1.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Grid.DrawEvery = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.Gray;
            this.tChart1.Axes.Left.Labels.Font.Size = 9;
            this.tChart1.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Left.Title.Font.Size = 11;
            this.tChart1.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Right.Labels.Font.Size = 9;
            this.tChart1.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Axes.Top.Labels.Font.Size = 9;
            this.tChart1.Axes.Top.Labels.Font.SizeFloat = 9F;
            this.tChart1.CurrentTheme = Steema.TeeChart.ThemeType.Report;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.Gray;
            this.tChart1.Header.Font.Size = 12;
            this.tChart1.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tChart1.Legend.Font.Size = 9;
            this.tChart1.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            this.tChart1.Legend.Shadow.Visible = false;
            this.tChart1.Legend.Transparent = true;
            this.tChart1.Location = new System.Drawing.Point(30, 21);
            this.tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.Visible = false;
            // 
            // 
            // 
            this.tChart1.Panel.Pen.Visible = true;
            this.tChart1.Series.Add(this.points1);
            this.tChart1.Series.Add(this.points2);
            this.tChart1.Size = new System.Drawing.Size(454, 306);
            this.tChart1.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Back.Brush.Visible = false;
            this.tChart1.Walls.Back.Transparent = true;
            this.tChart1.Walls.Back.Visible = false;
            // 
            // points1
            // 
            this.points1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.points1.ColorEach = false;
            // 
            // 
            // 
            this.points1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.points1.Marks.ArrowLength = 10;
            // 
            // 
            // 
            this.points1.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.points1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.points1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.points1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.points1.Marks.Brush.Gradient.UseMiddle = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            // 
            // 
            // 
            this.points1.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
            // 
            // 
            // 
            this.points1.Marks.Shadow.Visible = false;
            // 
            // 
            // 
            this.points1.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
            this.points1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos")));
            this.points1.Marks.TailParams.Margin = 0F;
            this.points1.Marks.TailParams.PointerHeight = 5D;
            this.points1.Marks.TailParams.PointerWidth = 8D;
            this.points1.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
            this.points1.OriginalCursor = null;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            // 
            // 
            // 
            this.points1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.points1.Pointer.Dark3D = false;
            this.points1.Pointer.Draw3D = false;
            this.points1.Pointer.HorizSize = 1;
            this.points1.Pointer.SizeDouble = 0D;
            this.points1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.points1.Pointer.VertSize = 1;
            this.points1.Title = "points1";
            this.points1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.points1.XValues.DataMember = "X";
            this.points1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.points1.YValues.DataMember = "Y";
            // 
            // chartLayout1
            // 
            this.chartLayout1.AutoScroll = true;
            this.chartLayout1.Controls.Add(this.tChart1);
            this.chartLayout1.Location = new System.Drawing.Point(39, 130);
            this.chartLayout1.Name = "chartLayout1";
            this.chartLayout1.Size = new System.Drawing.Size(516, 354);
            this.chartLayout1.TabIndex = 1;
            // 
            // points2
            // 
            this.points2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            this.points2.ColorEach = false;
            // 
            // 
            // 
            this.points2.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(124)))), ((int)(((byte)(62)))));
            // 
            // 
            // 
            this.points2.Marks.ArrowLength = 10;
            // 
            // 
            // 
            this.points2.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.points2.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.points2.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.points2.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.points2.Marks.Brush.Gradient.UseMiddle = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points2.Marks.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            // 
            // 
            // 
            this.points2.Marks.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(186)))), ((int)(((byte)(94)))));
            // 
            // 
            // 
            this.points2.Marks.Shadow.Visible = false;
            // 
            // 
            // 
            this.points2.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
            this.points2.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.points2.Marks.TailParams.Margin = 0F;
            this.points2.Marks.TailParams.PointerHeight = 5D;
            this.points2.Marks.TailParams.PointerWidth = 8D;
            this.points2.Marks.TailStyle = Steema.TeeChart.Styles.MarksTail.WithPointer;
            this.points2.OriginalCursor = null;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points2.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            // 
            // 
            // 
            this.points2.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
            this.points2.Pointer.SizeDouble = 0D;
            this.points2.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.points2.Title = "points2";
            this.points2.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.points2.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 533);
            this.Controls.Add(this.chartLayout1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.chartLayout1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Points points1;
        private Steema.TeeChart.Components.ChartLayout chartLayout1;
        private Steema.TeeChart.Styles.Points points2;
    }
}

