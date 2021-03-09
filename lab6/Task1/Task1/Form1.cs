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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            String eventString = "";
            Refresh();
            switch (e.Button)
            {
                case MouseButtons.Left:
                    eventString = "Left";
                    break;
                case MouseButtons.Right:
                    eventString = "Right";
                    break;
                case MouseButtons.Middle:
                    eventString = "Middle";
                    break;
                case MouseButtons.None:
                default:
                    break;
            }
            Graphics dc = CreateGraphics();
            Font fnt = new Font("Arial", 20); //Шрифт Arial, размер 10
            dc.DrawString(eventString, fnt, Brushes.Blue, e.X, e.Y);
        }
    }
}
