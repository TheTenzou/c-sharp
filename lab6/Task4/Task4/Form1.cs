using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        int t = 0;
        bool inc = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            dc.DrawRectangle(Pens.RoyalBlue, 100 - t, 100 - t, 50 + 2 * t, 50 + 2 * t);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (inc) t += 2;
            else t -= 2;
            if (t > 99) inc = false;
            if (t < 1) inc = true;
            Invalidate();
        }
    }
}
