using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Refresh();
            int x, y;
            try
            {
                x = Convert.ToInt32(textBox1.Text);
                y = Convert.ToInt32(textBox2.Text);

                Graphics graphics = CreateGraphics();
                graphics.DrawEllipse(Pens.Silver, x, y, 100, 100);
            } 
            catch
            {
                MessageBox.Show("Wrong coordinats");
            }
        }
    }
}
