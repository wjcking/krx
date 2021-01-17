using AutoDesk;
using System;
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
           //     textBox1.AppendText(s + "~");
                label2.Text += appender.ToString();
                System.Threading.Thread.Sleep(10);
            }
        }

    }
}
