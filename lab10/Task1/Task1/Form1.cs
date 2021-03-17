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

        private void buttonCeateTable_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            DataTable Table1 = new DataTable();
            DataColumn column;
            DataRow row;
            column = new DataColumn();
            column.ColumnName = "Teacher_id";
            column.DataType = typeof(int);
            column.AutoIncrement = true;
            Table1.Columns.Add(column);

            Table1.TableName = "Teachers";
            column = new DataColumn();

            column.ColumnName = "Name";
            column.DataType = typeof(string);
            Table1.Columns.Add(column);


            row = Table1.NewRow();
            row["Name"] = "First teacher";
            Table1.Rows.Add(row);

            row = Table1.NewRow();
            row["Name"] = "Second teacher";
            Table1.Rows.Add(row);

            row = Table1.NewRow();
            row["Name"] = "Third teacher";
            Table1.Rows.Add(row);

            row = Table1.NewRow();
            row["Name"] = "aa";
            Table1.Rows.Add(row);

            dataGridView1.DataSource = Table1;
            dataGridView1.Columns[1].Width = 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable t = new DataTable();
            t = (DataTable)dataGridView1.DataSource;
            MessageBox.Show(t.Rows[dataGridView1.CurrentCell.RowIndex][dataGridView1.CurrentCell.ColumnIndex].ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView((DataTable)dataGridView1.DataSource);
            dataView.Sort = textBox1.Text;
            dataGridView1.DataSource = dataView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataView dataView = new DataView((DataTable)dataGridView1.DataSource);
            dataView.RowFilter = textBox2.Text;
            dataGridView1.DataSource = dataView;
        }
    }
}
