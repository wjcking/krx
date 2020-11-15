using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTest
{
    public partial class Formwork : Form
    {
        public Formwork()
        {
            InitializeComponent();
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            var x = 100;
            var y = 0;


            var width = 1920;
            var height = 1080;
            var row = 0;
            var columns = 0;
            var tableString = new StringBuilder();
          //  rand = DateTime.Now.Millisecond;
            for (var i = 0; i < (width / 2); i++)
            {
                tableString.Append("<tr>");


                for (var c = 0; c < (height / 2); c++)

                    tableString.AppendFormat("<td>{0}</td>", DateTime.Now.Millisecond);

                tableString.Append("</tr>");
            }
            webBrowser1.DocumentText = tableString.ToString();
        }
    }
}
