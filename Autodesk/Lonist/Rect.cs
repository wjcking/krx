using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace AngelLayout
{
    public partial class Rect : Form
    {
        public Rect()
        {
            InitializeComponent();
     //       Draw();
        }
        public void Draw()
        {
            Bitmap image = new Bitmap(800, 600);
            //创建绘图对象Graphics
            Graphics graphics = Graphics.FromImage(image);
            //清除画布，背景颜色为红色
            graphics.Clear(Color.Silver);
            //通过循环画出横线
            for (int i = 0; i < 130; i++)
            {
                graphics.DrawLine(new Pen(Brushes.Black, 1), 0, i * 20, 300, i * 20);
            }
            //通过循环画出竖线
            for (int i = 0; i < 120; i++)
            {
                graphics.DrawLine(new Pen(Brushes.Black, 1), i * 20, 0, i * 20, 600);
            }

            this.BackgroundImage = image;
            //加边框
            graphics.DrawRectangle(new Pen(Color.Black), 0, 0, image.Width - 1, image.Height - 1);
            //设置图片平铺方式
            this.BackgroundImageLayout = ImageLayout.None;
        }
        private void Rect_Load(object sender, EventArgs e)
        {

        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Red), 10, 20, 45,45);
            //e.ClipRectangle.Inflate(50, 50);
  
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
