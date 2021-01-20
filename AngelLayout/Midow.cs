using AutoDesk;
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

         
            checkedListBox2.ColumnWidth = 3;
             label2.BringToFront();
            
     
         

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

        private void label2_Paint(object sender, PaintEventArgs e)
        {
            //          try
            //          {
            //              //取得这个绘图对象Graphics
            //              Graphics g = e.Graphics;
            //              //绘制底色
            //              Brush b = new SolidBrush(BackColor);

            //              g.FillRectangle(b, e.ClipRectangle);

            //              //绘制第一段文本
            //              //Brush bRed = new SolidBrush(Color.Red);                                  //头两个字符用红色绘制
            //              //g.DrawString(textBox1.Text.Substring(0, 2), this.Font, bRed, e.ClipRectangle);    //在失效区域内绘制

            //              SizeF size1 = g.MeasureString(Text.Substring(0, 2), this.Font);          //计算头两个字符绘制后的大小
            //              Rectangle rect2 = e.ClipRectangle;                        //计算绘制完头两个字符后的失效区域
            //rect2.X = (int)(e.ClipRectangle.Left + size1.Width);
            //              //rect2.Width = (int)(e.ClipRectangle.Width - size1.Width);

            //              var myPen = new Pen(Color.White, 1);
            //              g.DrawRectangle(myPen, rect2.X, 0, this.Font.Size, this.Font.Size);



            //              //Brush bGreen = new SolidBrush(Color.Green);                               //绘制后面的字符，用绿色
            //              //g.DrawString(textBox1.Text.Substring(2), this.Font, bGreen, rect2);
            //          }
            //          catch(Exception y)
            //          {
            //              label1.Text = y.Message;
            //          }
        }

        private void label2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox1.Text = Komad.Batch("file-search.bat", this.toolStripTextBox1.Text);
        }



        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
          //  textBox1.Text = Komad.Batch(toolStripTextBox1.Text);

            //var cybert = new Cyper(textBox1.Text);
            //var strings = cybert.GetCharArray(textBox2.Text);
            //var appender = new System.Text.StringBuilder(); 
            //foreach (var s in strings)
            //{
            //   appender.Append(s + "~");
            ////textBox1.AppendText(s + "~");   // 
            ////    System.Threading.Thread.Sleep(10);
            //}
            ////  label2.Text  = appender.ToString();
            //label2.Refresh();
        }

        private void toolGrid_Click(object sender, EventArgs e)
        {
            new Grid().Show();
        }

        private void Levis_Click(object sender, EventArgs e)
        {
            new Levis().Show();
        }

        private void Rect_Click(object sender, EventArgs e)
        {

            new Rect().Show();
        }
    }
}
