
using JoyKeys.Voluntary;
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
            JoystickAPI.JOYINFOEX infoEx = new JoystickAPI.JOYINFOEX();
            infoEx.dwSize = Marshal.SizeOf(typeof(JoystickAPI.JOYINFOEX));
            infoEx.dwFlags = (int)JoystickAPI.JOY_RETURNBUTTONS;
            int result = JoystickAPI.joyGetPosEx(JoystickAPI.JOYSTICKID1, ref infoEx);

            //textBox1.AppendText(ayric_utiliz.screenQheight.ToString());
            //textBox1.AppendText(Environment.NewLine);
            //textBox1.AppendText(ayric_utiliz.screenQwidth.ToString());
            textBox1.AppendText(aryic_screen.dpix.ToString());
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(aryic_screen.dpiy.ToString());


            textBox1.AppendText(Environment.NewLine);

            textBox1.AppendText(aryic_screen.scalex.ToString());
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(aryic_screen.scaley.ToString());


            textBox1.AppendText(Environment.NewLine);

            textBox1.AppendText(aryic_screen.desktop.Height.ToString());
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(aryic_screen.desktop.Width.ToString());

            textBox1.AppendText(Environment.NewLine);

            textBox1.AppendText(aryic_screen.work_area.Height.ToString());
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(aryic_screen.work_area.Width.ToString());

            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(aryic_screen.bound_height.ToString());
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(aryic_screen.bound_width.ToString());

            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(  System.Drawing.SystemFonts.DefaultFont.Name);
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(System.Drawing.SystemFonts.DefaultFont.Size.ToString());
   

        }
        #region 无边框拖动效果
        [DllImport("user32.dll")]//拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void Start_MouseDown(object sender, MouseEventArgs e)
        {
            //拖动窗体
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion
        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //label1.ForeColor = Pixels.GetColor(e.X, e.Y, this);
            //label1.Text = Pixels.GetColor(e.X, e.Y, this).ToString();
        }



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

        private void Levis_Click(object sender, EventArgs e)
        {
            new Levis().Show();
        }

        private void Rect_Click(object sender, EventArgs e)
        {

            new Rect().Show();
        }



        private void Midow_Load(object sender, EventArgs e)
        {
            //instant itt = new instant();
            //itt.eydix = 0;
            //itt.issaic.record();
            //textBox1.Text = itt.issaic.isakes.ToString();
        }

        private void Rabber_Click(object sender, EventArgs e)
        {
            new Komet().Show();
        }

        private void Karet_Click(object sender, EventArgs e)
        {
            new Karet().Show();
        }

        private void Curl_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = Komad.Batch("curl.exe", textBox.Text);
        }

        private void ShapeF_Click(object sender, EventArgs e)
        {
            new FormShape().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cybert cyb = new cybert();
            cyb.orginal = textBox1.Text;

            textBox2.Text = cyb.each_ranket();
            textBox3.Text = cyb.each_eidix();
            textBox4.Text = cyb.each_hexet();
        }
    }
}
