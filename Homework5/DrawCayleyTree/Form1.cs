using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawCayleyTree
{
    public partial class Form1 : Form
    {
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        int leng = 100;
        Graphics graphics;
        Pen myPen;
        float width = 1.5f;
        public Form1()
        {           
            InitializeComponent();
            graphics = this.CreateGraphics();
            graphics.Clip = new Region(new Rectangle(0, 0, 1200, 700));
            myPen = new Pen(Color.Blue, width);
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.Wheat);
            drawCayleyTree(10, 400, 500, leng, -Math.PI / 2);           
        }

        void drawCayleyTree(int n,
            double x0, double y0, double leng, double th)
        {
            if (n == 0) return;
            
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
                myPen,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            th1 = trackBar1.Value * Math.PI / 180;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            th2 = trackBar2.Value * Math.PI / 180;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            leng = trackBar3.Value;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            per1 = trackBar4.Value / 10.0;
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            per2 = trackBar5.Value / 10.0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s=comboBox1.SelectedItem.ToString();
            Color tempColor;
            switch(s)
            {
                case "Black":tempColor = Color.Black;break;
                case "Blue": tempColor = Color.Blue; break;
                case "Yellow": tempColor = Color.Yellow; break;
                case "Red": tempColor = Color.Red; break;
                case "Green": tempColor = Color.Green; break;
                default:
                    tempColor = Color.Green;break;
            }
            myPen.Color = tempColor;
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            myPen.Width = trackBar6.Value/10.0f;
        }
    }
}
