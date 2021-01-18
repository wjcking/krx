using AutoDesk;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace AngelLayout
{
    public partial class Midow : Form
    {
        public Midow()
        {
            InitializeComponent();
            //var symbolics = new Symbolics();
            //symbolics.MdiParent = this;
            //symbolics.Show();

            //var main = new AsnicForm();
            //main.MdiParent = this;//子窗体的父窗体是当前窗体
            //main.WindowState = FormWindowState.Maximized;//子窗体
            //main.Show();  

            //      Application.AddMessageFilter(this);
        }
        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //label1.ForeColor = Pixels.GetColor(e.X, e.Y, this);
            //label1.Text = Pixels.GetColor(e.X, e.Y, this).ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var cybert = new Cybert(textBox1.Text);
            var strings = cybert.GetCharArray(textBox2.Text);
            var appender = new System.Text.StringBuilder(); 
            foreach (var s in strings)
            {
               appender.Append(s + "~");
            //textBox1.AppendText(s + "~");   // 
            //    System.Threading.Thread.Sleep(10);
            }
            //  label2.Text  = appender.ToString();
            label2.Refresh();
        }

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
    }
}
