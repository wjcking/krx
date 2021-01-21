
using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace AngelLayout
{
    public partial class Midow : Form
    {
        public Midow()
        {
            InitializeComponent();
            DoubleBuffered = true;
            

            //dataGridView1.DataSource = this.dataGridView1;
            //tableLayoutPanel1.dou
            //var symbolics = new Symbolics();
            //symbolics.MdiParent = this;
            //symbolics.Show();

            //var main = new AsnicForm();
            //main.MdiParent = this;//子窗体的父窗体是当前窗体
            //main.WindowState = FormWindowState.Maximized;//子窗体
            //main.Show();  


        //    label2.BringToFront();
        //      Application.AddMessageFilter(this);
        }
        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //label1.ForeColor = Pixels.GetColor(e.X, e.Y, this);
            //label1.Text = Pixels.GetColor(e.X, e.Y, this).ToString();
        }
        //     [ DllImport("User32.dll", CharSet = CharSet.Auto)]
        //     public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        //     [DllImport("User32.dll")]
        //     private static extern IntPtr GetWindowDC(IntPtr hWnd);

        //     protected override void WndProc(ref Message m)
        //     {
        //         base.WndProc(ref m);
        //         const int WM_NCPAINT = 0x85;
        ////      if (m.Msg == WM_NCPAINT)
        //     //    {
        //             IntPtr hdc = GetWindowDC(m.HWnd);
        //             if ((int)hdc != 0)
        //             {
        //                 Graphics g = Graphics.FromHdc(hdc);
        //                 g.FillRectangle(Brushes.Green, new Rectangle(0, 0, 4800, 23));
        //                 g.Flush();
        //                 ReleaseDC(m.HWnd, hdc);
        //             }
        //    //     }
        //     }
         

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //    textBox1.Text = Komad.Batch("file-search.bat", this.toolStripTextBox1.Text);
        }



        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
          //  textBox1.Text = Komad.Batch(toolStripTextBox1.Text);

        }

        private void toolGrid_Click(object sender, EventArgs e)
        {
            new Grid().Show();
        }



        private void Rect_Click(object sender, EventArgs e)
        {

            new Rect().Show();
        }


 
        private void Midow_Load(object sender, EventArgs e)
        {

        }

        private void Rabber_Click(object sender, EventArgs e)
        {
            new Komet().Show();
        }

        private void Karet_Click(object sender, EventArgs e)
        {
    new Karet().Show();
        }

        private void Levis_Click_1(object sender, EventArgs e)
        {
     new Levis().Show();
        }
    }
}
