using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int t = 10;
            Refresh();
            Pen pen = new Pen(Color.Black);
            Graphics g = CreateGraphics();

            Rectangle screenRectangle = this.RectangleToScreen(this.ClientRectangle);

            int new_x = Form1.MousePosition.X - t / 2 - screenRectangle.Left;
            int new_y = Form1.MousePosition.Y - t / 2 - screenRectangle.Top;
            g.DrawEllipse(pen, new_x, new_y, t, t);
        }
    }
}
