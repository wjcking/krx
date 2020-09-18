using Beautiful;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Console;
using Business;
using System.Text;
using System.IO;
using System;
using System.Reflection;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        public void reflect()
        {
            //F:\VSProjects\AngelWolf\Business\Category.cs

            Type t = typeof(Category);//类名
                                      // t.GetMethod
                                      //  MethodInfo mt = t.GetMethod(Event);//加载方法
                                      //   string DoRet = mt.Invoke(this, new object[] { pra1, pra2, pra3 }).ToString();//执行

            //通过反射来执行类的静态方法
            Type tx = typeof(Business.Category);
            MethodInfo mf = tx.GetMethod("GetJsonLis2t", BindingFlags.Public | BindingFlags.Static, null, new Type[] { }, null);
            string saf = (string)mf.Invoke(null, null);

            Console.WriteLine(saf);
        }

        /// <summary>
        ///now is from the left, mind the reverse from bottom
        /// </summary>
        public class Ket
        {
            int Line;
            int End;
            //char[] 1 to N subscript
            int Pine;
            int aup;
            int index;
            ushort asc;
            char value;
        }
        [TestMethod]
        public void Testkets()
        {
            var bytes = File.ReadAllBytes(@"F:\VSProjects\AngelWolf\Rastera\asnic\rastera\ketself.html");
            var lines = File.ReadAllLines(@"F:\VSProjects\AngelWolf\Rastera\asnic\rastera\ketself.html");
            char[] kets;

            int index = 0;
            //   var len = lines.GetUpperBound(1);
            var len = 0;
            //foreach (var line in lines)
            //    WriteLine(line.l);
            var sb = new StringBuilder();
            sb.Append("<html>");
            sb.Append("<body style=\"background-color: \">");
            sb.Append("<table>");

            foreach (var line in lines)
            {
                sb.AppendLine("<tr>");
                bool isLengthed = line.Length > len;
                    len = line.Length;
                ++index;
                //   Write("[" + index + "]");
                kets = line.ToCharArray();
                foreach (var k in kets)
                {
                    //web.dot11 dash.5ㄱ
                    sb.AppendLine("<td style='border:0.5px solid black'>");
                    sb.Append(k);
                    sb.AppendLine("</td>");
                }
                sb.AppendLine("</tr>");
            }
            sb.Append("</table>");
            File.WriteAllText(@"C:\Users\Administrator\Desktop\kets.html", sb.ToString());
            // Console.Write(sb.ToString());
            //for (int i = 0; i < len; i++)
            //    Write("--");
            sb.Append("</body></html>");
        }
    }
}
