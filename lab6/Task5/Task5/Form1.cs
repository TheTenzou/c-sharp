using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        int t = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int width_rec = 100;
            Graphics graphics = e.Graphics;

            Rectangle rec_left = new Rectangle(200 + t, 200 + t, width_rec, width_rec);
            Rectangle rec_right = new Rectangle(200 - t, 200 - t, width_rec, width_rec);

            graphics.DrawRectangle(Pens.RoyalBlue, rec_left);
            graphics.DrawRectangle(Pens.RoyalBlue, rec_right);

            graphics.DrawRectangle(Pens.GreenYellow, Rectangle.Intersect(rec_left, rec_right));

            graphics.DrawRectangle(Pens.DarkKhaki, Rectangle.Union(rec_left, rec_right));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t += 2;
            Invalidate();
        }
    }
}
