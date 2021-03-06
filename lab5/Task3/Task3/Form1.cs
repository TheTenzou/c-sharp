using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        int x, y, z, w;

        private void buttonRec_Click(object sender, EventArgs e)
        {
            Refresh();
            ReadCoordinats();
            Random random = new Random();
            Pen pen = new Pen(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));

            Graphics graphics = CreateGraphics();

            graphics.DrawRectangle(pen, x, y, z, w);
        }

        private void buttonElips_Click(object sender, EventArgs e)
        {
            Refresh();
            ReadCoordinats();
            Random random = new Random();
            Pen pen = new Pen(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));

            Graphics graphics = CreateGraphics();

            graphics.DrawEllipse(pen, x, y, z, w);
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            Refresh();
            ReadCoordinats();
            Random random = new Random();
            Pen pen = new Pen(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));

            Graphics graphics = CreateGraphics();

            graphics.DrawLine(pen, x, y, z, w);

        }

        public Form1()
        {
            InitializeComponent();
        }
        
        private void ReadCoordinats()
        {
            try
            {
                x = Convert.ToInt32(textBoxX.Text);
                y = Convert.ToInt32(textBoxY.Text);
                z = Convert.ToInt32(textBoxZ.Text);
                w = Convert.ToInt32(textBoxW.Text);
            }
            catch
            {
                MessageBox.Show("Wrong coordinats");
            }
        }
    }
}
