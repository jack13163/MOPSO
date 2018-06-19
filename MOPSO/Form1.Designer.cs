namespace MOPSO
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.btnStart = new System.Windows.Forms.Button();
            this.tChart1 = new Steema.TeeChart.TChart();
            this.points1 = new Steema.TeeChart.Styles.Points();
            this.line1 = new Steema.TeeChart.Styles.Line();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtXEnd = new System.Windows.Forms.TextBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(787, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tChart1
            // 
            // 
            // 
            // 
            this.tChart1.Aspect.ColorPaletteIndex = 3;
            this.tChart1.Aspect.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.tChart1.Aspect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
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
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Labels.Font.Name = "Arial";
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Bottom.TicksInner.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Bottom.Title.Font.Name = "Arial";
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Labels.Font.Name = "Arial";
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Depth.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Depth.TicksInner.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Depth.Title.Font.Name = "Arial";
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Labels.Font.Name = "Arial";
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.DepthTop.TicksInner.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.DepthTop.Title.Font.Name = "Arial";
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Labels.Font.Name = "Arial";
            // 
            // 
            // 
            this.tChart1.Axes.Left.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Left.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Left.TicksInner.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Left.Title.Font.Name = "Arial";
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Labels.Font.Name = "Arial";
            // 
            // 
            // 
            this.tChart1.Axes.Right.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Right.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Right.TicksInner.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Right.Title.Font.Name = "Arial";
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Labels.Font.Name = "Arial";
            // 
            // 
            // 
            this.tChart1.Axes.Top.Ticks.Length = 2;
            // 
            // 
            // 
            this.tChart1.Axes.Top.TicksInner.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Axes.Top.TicksInner.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Axes.Top.Title.Font.Name = "Arial";
            this.tChart1.CurrentTheme = Steema.TeeChart.ThemeType.XP;
            this.tChart1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart1.Header.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Header.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Header.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Header.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.tChart1.Header.Font.Name = "Arial";
            // 
            // 
            // 
            this.tChart1.Header.Shadow.Height = 0;
            this.tChart1.Header.Shadow.Width = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Legend.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart1.Legend.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Legend.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Legend.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Legend.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Legend.Brush.Gradient.Visible = true;
            // 
            // 
            // 
            this.tChart1.Legend.Font.Name = "Arial";
            this.tChart1.Location = new System.Drawing.Point(11, 111);
            this.tChart1.Name = "tChart1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Panel.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tChart1.Panel.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Panel.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Panel.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Panel.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Panel.Brush.Gradient.UseMiddle = false;
            // 
            // 
            // 
            this.tChart1.Panel.Pen.Width = 6;
            // 
            // 
            // 
            this.tChart1.Panel.Shadow.Height = 0;
            this.tChart1.Panel.Shadow.Width = 0;
            this.tChart1.Series.Add(this.points1);
            this.tChart1.Series.Add(this.line1);
            this.tChart1.Size = new System.Drawing.Size(923, 554);
            this.tChart1.TabIndex = 5;
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
            this.tChart1.Walls.Back.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Back.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Back.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Walls.Back.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Walls.Back.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tChart1.Walls.Back.Brush.Gradient.Visible = false;
            this.tChart1.Walls.Back.Brush.Visible = false;
            this.tChart1.Walls.Back.Transparent = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Bottom.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Bottom.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Walls.Bottom.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            this.tChart1.Walls.Left.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Left.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Left.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Walls.Left.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Walls.Left.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.tChart1.Walls.Right.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.tChart1.Walls.Right.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Right.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tChart1.Walls.Right.Brush.Gradient.SigmaFocus = 0F;
            this.tChart1.Walls.Right.Brush.Gradient.SigmaScale = 0F;
            this.tChart1.Walls.Right.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // points1
            // 
            this.points1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.points1.ColorEach = true;
            // 
            // 
            // 
            this.points1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            // 
            // 
            // 
            this.points1.Marks.ArrowLength = 10;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.points1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.points1.Marks.Brush.Gradient.SigmaFocus = 0F;
            this.points1.Marks.Brush.Gradient.SigmaScale = 0F;
            this.points1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.points1.Marks.Brush.Gradient.Visible = true;
            // 
            // 
            // 
            this.points1.Marks.Font.Name = "Arial";
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
            this.points1.Marks.TailParams.PointerHeight = 8D;
            this.points1.Marks.TailParams.PointerWidth = 8D;
            this.points1.OriginalCursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            // 
            // 
            // 
            this.points1.Pointer.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.points1.Pointer.Brush.ForegroundColor = System.Drawing.Color.Empty;
            // 
            // 
            // 
            this.points1.Pointer.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.points1.Pointer.Dark3D = false;
            this.points1.Pointer.HorizSize = 2;
            // 
            // 
            // 
            this.points1.Pointer.Pen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.points1.Pointer.SizeDouble = 0D;
            this.points1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.points1.Pointer.Style = Steema.TeeChart.Styles.PointerStyles.Star;
            this.points1.Pointer.VertSize = 2;
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
            // line1
            // 
            // 
            // 
            // 
            this.line1.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.line1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
            this.line1.ColorEach = false;
            // 
            // 
            // 
            this.line1.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(92)))), ((int)(((byte)(128)))));
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.line1.Marks.Brush.Gradient.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.line1.Marks.Brush.Gradient.MiddleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.line1.Marks.Brush.Gradient.SigmaFocus = 0F;
            this.line1.Marks.Brush.Gradient.SigmaScale = 0F;
            this.line1.Marks.Brush.Gradient.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.line1.Marks.Brush.Gradient.Visible = true;
            // 
            // 
            // 
            this.line1.Marks.Font.Name = "Arial";
            // 
            // 
            // 
            this.line1.Marks.Shadow.Visible = false;
            // 
            // 
            // 
            this.line1.Marks.TailParams.Align = Steema.TeeChart.Styles.TailAlignment.Auto;
            this.line1.Marks.TailParams.CustomPointPos = ((System.Drawing.PointF)(resources.GetObject("resource.CustomPointPos1")));
            this.line1.Marks.TailParams.Margin = 0F;
            this.line1.Marks.TailParams.PointerHeight = 5D;
            this.line1.Marks.TailParams.PointerWidth = 8D;
            this.line1.OriginalCursor = null;
            // 
            // 
            // 
            this.line1.Pointer.SizeDouble = 0D;
            this.line1.Pointer.SizeUnits = Steema.TeeChart.Styles.PointerSizeUnits.Pixels;
            this.line1.Title = "line1";
            this.line1.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.line1.XValues.DataMember = "X";
            this.line1.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.line1.YValues.DataMember = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "X:";
            // 
            // txtXStart
            // 
            this.txtXStart.Location = new System.Drawing.Point(59, 22);
            this.txtXStart.Name = "txtXStart";
            this.txtXStart.Size = new System.Drawing.Size(50, 25);
            this.txtXStart.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "-";
            // 
            // txtXEnd
            // 
            this.txtXEnd.Location = new System.Drawing.Point(136, 22);
            this.txtXEnd.Name = "txtXEnd";
            this.txtXEnd.Size = new System.Drawing.Size(50, 25);
            this.txtXEnd.TabIndex = 9;
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(669, 15);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(95, 35);
            this.btnInit.TabIndex = 10;
            this.btnInit.Text = "初始化";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 677);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.txtXEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtXStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tChart1);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Text = "基于粒子群算法的多目标优化算法";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private Steema.TeeChart.TChart tChart1;
        private Steema.TeeChart.Styles.Points points1;
        private Steema.TeeChart.Styles.Line line1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtXEnd;
        private System.Windows.Forms.Button btnInit;
    }
}

