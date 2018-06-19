using Steema.TeeChart.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.tChart1.Header.Text = "测试";

            int[] xs = new int[] { 1, 2, 3, 4, 5 };
            int[] ys = new int[] { 1, 2, 3, 4, 5 };
            this.points1.Add(xs, ys);

            int[] x2s = new int[] { 8, 12, 13, 7, 15 };
            int[] y2s = new int[] { 1, 2, 3, 4, 5 };
            this.points2.Add(x2s, y2s);
        }
    }
}
