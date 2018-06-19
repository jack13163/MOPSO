using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MOPSOLIB;
using System.Threading;

namespace MOPSO
{
    public partial class MainFrm : Form
    {
        /// <summary>
        /// 群体最优（精英种群）
        /// </summary>
        public static Double gBest = 0;

        /// <summary>
        /// 粒子个数
        /// </summary>
        public static int birdnum = 10;

        /// <summary>
        /// 种群粒子分布的标准差
        /// </summary>
        public static double stdd = 65535;

        /// <summary>
        /// 种群
        /// </summary>
        public static List<Bird> birds = null;

        public static Random rand = new Random();

        /// <summary>
        /// 惯性权重
        /// </summary>
        private double w = 0.8;
        /// <summary>
        /// 个人权重
        /// </summary>
        private double c1 = 2;
        /// <summary>
        /// 群体权重
        /// </summary>
        private double c2 = 2;

        public MainFrm()
        {
            InitializeComponent();

            //设置标题
            this.tChart1.Header.Text = "粒子群算法求最小值演示程序";
            this.btnStart.Enabled = false;
            this.txtXStart.Text = "0";
            this.txtXEnd.Text = "10";
        }

        /// <summary>
        /// 显示种群当前的状态
        /// </summary>
        /// <param name="birds"></param>
        public void ShowSwarm(List<Bird> birds)
        {
            double[] xs = new double[birds.Count];
            double[] ys = new double[birds.Count];

            //绘图
            for (int i = 0; i < birds.Count; i++)
            {
                xs[i] = birds[i].X;
                ys[i] = F1(birds[i].X);
            }
            //绘制散点
            this.points1.Clear();
            this.points1.Add(xs, ys);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            BackgroundWorker bw1 = new BackgroundWorker();
            bw1.DoWork += Bw1_DoWork;
            bw1.RunWorkerCompleted += Bw1_RunWorkerCompleted;

            bw1.RunWorkerAsync();
        }

        private void Bw1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("最优值：(" + gBest + "," + F1(gBest) + ")");
        }

        private void Bw1_DoWork(object sender, DoWorkEventArgs e)
        {
            run();
        }

        /// <summary>
        /// 产生离散点
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public double[] getLineData(double start, double end, int num)
        {
            double l = end - start;
            double step = 0;
            double[] x = new double[num];
            if (l > 0)
            {
                step = l / num;
                for (int i = 0; i < num; i++)
                {
                    x[i] = start + step * i;
                }
            }
            return x;
        }

        /// <summary>
        /// 目标函数
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static double F1(double x)
        {
            return x * 2 + 1 / x;
        }

        /// <summary>
        /// 创建鸟类种群
        /// </summary>
        /// <param name="xmin"></param>
        /// <param name="xmax"></param>
        /// <param name="vmin"></param>
        /// <param name="vmax"></param>
        /// <param name="birdnum"></param>
        /// <returns></returns>
        public List<Bird> createBird(int xmin, int xmax, int vmin, int vmax, int birdnum)
        {
            birds = new List<Bird>();
            for (int i = 0; i < birdnum; i++)
            {
                Bird bird = new Bird();

                double x = rand.NextDouble() * xmax;
                double v = rand.NextDouble() * vmax;

                bird.X = x;
                bird.Best = x;

                if (gBest == 0 || F1(x) < F1(gBest))
                {
                    gBest = x;//求最小值
                }
                bird.V = v;
                birds.Add(bird);
            }

            //显示种群当前状态
            ShowSwarm(birds);

            return birds;
        }

        /// <summary>
        /// 运行
        /// </summary>
        /// <param name="fun"></param>
        public void run()
        {
            int count = 0;
            double rand1 = rand.NextDouble();
            double rand2 = rand.NextDouble();
            //根据标准差（种群中粒子的分布的离散程度）和最大迭代次数进行收敛判断
            while (count < 50000 && stdd > 0.0001)
            {
                Thread.Sleep(100);

                foreach (Bird b in birds)
                {
                    double oldValue = F1(b.Best);

                    b.V = (w * b.V + c1 * rand1 * (b.Best - b.X) + c2 * rand2 * (gBest - b.X));
                    if ((b.X + b.V) > Double.Parse(txtXStart.Text) && (b.X + b.V) < Double.Parse(txtXEnd.Text))
                    {
                        b.X = b.X + b.V;
                    }
                    else if((b.X + b.V) < Double.Parse(txtXStart.Text))
                    {
                        b.X = Double.Parse(txtXStart.Text);
                    }
                    else
                    {
                        b.X = Double.Parse(txtXEnd.Text);
                    }

                    if (F1(b.X) < oldValue)
                    {
                        b.Best = b.X;
                    }
                    if (F1(b.X) < F1(gBest))
                    {
                        gBest = b.X;
                    }
                }

                ShowSwarm(birds);

                double[] x = new double[birdnum];
                //计算种群的离散程度
                for (int i = 0; i < birds.Count; i++)
                {
                    x[i] = birds[i].X;
                }
                stdd = StDev(x);

                count++;
            }
        }

        /// <summary>
        /// 计算标准差
        /// </summary>
        /// <param name="arrData"></param>
        /// <returns></returns>
        public static double StDev(double[] arrData) 
        {
            double xSum = 0;
            double xAvg = 0;
            double sSum = 0;
            double tmpStDev = 0;
            int arrNum = arrData.Length;
            for (int i = 0; i < arrNum; i++)
            {
                xSum += arrData[i];
            }
            xAvg = xSum / arrNum;
            for (int j = 0; j < arrNum; j++)
            {
                sSum += ((arrData[j] - xAvg) * (arrData[j] - xAvg));
            }
            tmpStDev = Convert.ToSingle(Math.Sqrt((sSum / (arrNum - 1))).ToString());
            return tmpStDev;
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            double xstart = Double.Parse(this.txtXStart.Text);
            double xend = Double.Parse(this.txtXEnd.Text);

            //设置坐标轴标签
            //this.tChart1.Axes.Bottom.SetMinMax(xstart, xend);

            //绘制曲线
            this.line1.Title = "目标函数";
            double[] xs2 = getLineData(xstart, xend, (int)(xend - xstart) * 20);
            double[] ys2 = new double[xs2.Length];
            for (int i = 0; i < xs2.Length; i++)
            {
                ys2[i] = F1(xs2[i]);
            }
            this.line1.Add(xs2, ys2);

            this.points1.Title = "粒子";

            int xmin = -5;
            int xmax = 5;
            int vmin = -2;
            int vmax = 2;

            //创建种群
            createBird(xmin, xmax, vmin, vmax, birdnum);
            this.btnStart.Enabled = true;
        }
    }
}
