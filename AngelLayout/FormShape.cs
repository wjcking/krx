using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AngelLayout
{
   
    public partial class FormShape : Form
    {
        private Point mouseOffset;        //记录鼠标指针的坐标  

    private bool isMouseDown = false; //记录鼠标按键是否按下
        private static Bitmap Cached = new Bitmap(@"C:\Users\Administrator\Desktop\Desk12-15\AirlFleadO.png");
        public FormShape()
        {
            InitializeComponent();
           
            BitmapRegion.CreateControlRegion(this, Cached);
 
        }

        private void FormShape_Load(object sender, EventArgs e)
        {
       
        }
 

        private void FormShape_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void FormShape_MouseUp(object sender, MouseEventArgs e)
        {
            // 修改鼠标状态isMouseDown的值 
            // 确保只有鼠标左键按下并移动时，才移动窗体 
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void FormShape_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
