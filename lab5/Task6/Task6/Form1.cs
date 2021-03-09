using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        int x = 50;
        int y = 50;
        int r = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down) y += 10;
            if (e.KeyData == Keys.Up) y -= 10;
            if (e.KeyData == Keys.Left) x -= 10;
            if (e.KeyData == Keys.Right) x += 10;
            Refresh();
            Pen pen = new Pen(Color.Black);
            Graphics g = CreateGraphics();
            g.DrawEllipse(pen, x, y, r, r);

        }
    }
}
