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
        }   [TestMethod]
        public void Testkets()
        {
            var bytes = File.ReadAllBytes(@"e:\VSProjects\AngelWolf\Rastera\asnic\rastera\ketself.html");
            var lines = File.ReadAllLines(@"e:\VSProjects\AngelWolf\Rastera\asnic\rastera\ketself.html");
            char[] kets;

            int index = 0;
            //   var len = lines.GetUpperBound(1);
            var len = 0;
            //foreach (var line in lines)
            //    WriteLine(line.l);
            var sb = new StringBuilder();
 
            sb.Append("<table style=\"background-color: \"> ");

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
            Console.Write(sb.ToString());
            //for (int i = 0; i < len; i++)
            //    Write("--");
    
        }
        public class Preditor
        {
            int Columns { get; set; }
            int Length { get; set; }

            public Ket[,] kets;
            public Preditor()
            {
                kets = new Ket[Columns, Length];
            }
        }
        /// <summary>
        ///now is from the left, mind the reverse from bottom
        /// </summary>
        public class Ket
        {
            //Max length:left columns and RIGHT columns
            int Line;
            int End;
            //char[] 1 to N subscript
            int Pine;
            int Aup;

            int index;
            ushort Ascii;
            char value;
        }
     


    }
}
