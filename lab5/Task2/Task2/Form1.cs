using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        private Color color = Color.FromArgb((int)200, (int)200, (int)200);
        private Pen pen = new Pen(Color.Black);

        int x = 100;
        int y = 100;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = timer1.Enabled == false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            Graphics g = CreateGraphics();
            Random random = new Random();

            int v = 20; 
            int a = random.Next(0, 361);

            int vx = (int)(v * Math.Cos(a));
            int vy = (int)(v * Math.Sin(a));

            if (x + vx < 10) vx = -vx; 
            if (x + vx > 285) vx = -vx;
            if (y + vy < 10) vy = -vy;
            if (y + vy > 235) vy = -vy;

            x += vx; 
            y += vy;

            label4.Text = "x=" + x + " y=" + y;

            g.DrawEllipse(pen, x, y, 10, 10);

            Application.DoEvents();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int R, G, B;
            try
            {
                R = Convert.ToInt16(textBox1.Text);
                G = Convert.ToInt16(textBox2.Text);
                B = Convert.ToInt16(textBox3.Text);
                color = Color.FromArgb(200, 0, 0);
                pen = new Pen(color);
            }
            catch
            {
                MessageBox.Show("wrong color");
            }
        }
    }
}
