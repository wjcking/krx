using FastColoredTextBoxNS;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AngelLayout
{
    public partial class Karet : Form
    {
        public Karet()
        {
            InitializeComponent();
            fastColoredTextBox1.Language = Language.Custom;
        }

        private void fastColoredTextBox1_Load(object sender, System.EventArgs e)
        {

        }

        private void fastColoredTextBox1_TextChanging(object sender, FastColoredTextBoxNS.TextChangingEventArgs e)
        {
      
        }

        EllipseStyle ellipseStyle = new EllipseStyle();
        class EllipseStyle : Style
        {
            public override void Draw(Graphics gr, Point position, Range range)
            {
                //get size of rectangle
                Size size = GetSizeOfRange(range);
                //create rectangle
                Rectangle rect = new Rectangle(position, size);
                //inflate it
                rect.Inflate(2, 2);
                //get rounded rectangle
                //var path = new LineInfo();
                ////draw rounded rectangle
                //gr.DrawPath(Pens.Red, path);
            }
        }
            private void fastColoredTextBox1_TextChangedDelayed(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            Range range = (sender as FastColoredTextBox).VisibleRange;
          
            //clear style of changed range
            range.ClearStyle(ellipseStyle);
            //comment highlighting
            range.SetStyle(ellipseStyle, @"//.*$", RegexOptions.Multiline);
            range.SetStyle(ellipseStyle, @"(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline);
            range.SetStyle(ellipseStyle, @"(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline | RegexOptions.RightToLeft);
        }
    }
}
