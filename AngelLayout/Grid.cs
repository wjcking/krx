using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

using System.Windows.Forms;

namespace AngelLayout
{
    public partial class Grid : Form
    {

        public Grid()
        {
            InitializeComponent();    //网格宽300，高600
        
            Draw();
        }

        public void Draw()
        {
            DoubleBuffered = true;
            var properInfo = dataGridView1.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            properInfo.SetValue(dataGridView1, true, null);

            for (int t = 0; t < 1920 / 14; t++)
            {
                var header = new DataGridViewTextBoxColumn();
                header.Width = 14 + t.ToString().Length;
                //header.CellTemplate =
                //header.Width = 2 + 14 + 2;
                dataGridView1.Columns.Add(header);

                var row = new DataGridViewRow();
                row.Height = 14 + t.ToString().Length;

                var cell = new DataGridViewLinkCell();
                cell.Value = t;
                row.Cells.Add(cell);

                dataGridView1.Rows.Add(row);
                //dataGridView1.Columns[t]
            }
            dataGridView1.AutoGenerateColumns = true;

        }

        private void Grid_Load(object sender, EventArgs e)
        {

        }
    }
         
}
