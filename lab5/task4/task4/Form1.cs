using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4
{
    public partial class Form1 : Form
    {
        private Color color = Color.FromArgb((int)200, (int)200, (int)200);
        private Pen pen = new Pen(Color.Black);
        private Graphics g;
        private Random random = new Random();

        int x = 100;
        int y = 100;

        int size = 10;

        bool isMove = false;
        bool isScaling = false;
        bool incr = true;

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            isMove = false == isMove;
        }

        private void buttonSize_Click(object sender, EventArgs e)
        {
            isScaling = false == isScaling;
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {

            if (isMove)
            {
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
            }

            if (isScaling)
            {
                if (size > 40) incr = false;
                if (size < 10) incr = true;
                if (incr)
                    size += 5;
                else
                    size -= 5;
            }

            if (isMove || isScaling)
            {
                Refresh();
                g.DrawEllipse(pen, x, y, size, size);
            }

            Application.DoEvents();
        }
    }
}
