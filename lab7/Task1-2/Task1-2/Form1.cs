using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1_2
{
    public partial class Form1 : Form
    {
        private int width;
        private int height;
        private Color myColor;
        int x_rec = 50;
        int y_rec = 50;

        public Form1()
        {
            InitializeComponent();
            myColor = Color.Red;
            width = 10;
            height = 10;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
            Pen myPen = new Pen(myColor);
            dc.DrawRectangle(myPen, x_rec, y_rec, width, height);
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = 100;
            height = 100;
            Invalidate();
        }
        private void middleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = 55;
            height = 55;
            Invalidate();
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            width = 10;
            height = 10;
            Invalidate();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myColor = Color.Red;
            Invalidate();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myColor = Color.Blue;
            Invalidate();
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myColor = Color.Green;
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point myPoint = new Point(e.X, e.Y);
            if ((e.Button == MouseButtons.Right)
                && (x_rec <= e.X) & (e.X <= x_rec + width) & (y_rec <= e.Y) & (e.Y <= y_rec + height))
                contextMenuStrip1.Show(this, myPoint);
        }

    }
}
