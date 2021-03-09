using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Refresh();
            if (e.Button == MouseButtons.Right)
            {
                Graphics dc = CreateGraphics();
                dc.DrawLine(Pens.DarkTurquoise, 0, 0, e.X, e.Y);
            }
        }
    }
}
