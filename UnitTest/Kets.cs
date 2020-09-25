using Beautiful;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Console;
using Business;
using System.Text;
using System.IO;
using System;
using System.Reflection;
using HtmlAgilityPack;
using System.Linq;

namespace Preditor
{
    [TestClass]
    public class Preditor
    {
        protected static char[] Next = "\r\n".ToCharArray();
        /*C P P P P P P   C
        * L 0 1 2 3 4 5
        * L 1 a b c d e e t
        * L 2 啊是的方的
        * L 4 % % @ @ ！R E
        * C A A A A A A   C
        * 
        * Absoulute Solid.Metric.Matrix
        * Dot circle
        * Triangle Square 
        * Diamond
        */
        [TestMethod]
        public void printkets()
        {
            var doc = new HtmlDocument();
            // doc.Load(@"F:\VSProjects\AngelWolf\Rastera\asnic\template\anti-docx.html");
            doc.Load(@"C:\Users\Administrator\Desktop\keynote.txt",Encoding.GetEncoding("utf-8"));

            var xpath = "//head[@id='header']";
            var value = doc.DocumentNode.SelectNodes(xpath).First().InnerHtml;
            if (null == value)
                return;
            var lines = value.Split(Next, StringSplitOptions.RemoveEmptyEntries);
            int index = 0;
            char[] charLine;
            Line[] kets;
            for (int i = 0; i < lines.Length; i++)
            {
                charLine = lines[i].ToCharArray();
                kets = new Line[lines.Length];
                kets[i] = new Line();
                kets[i].Left = i;
                var sb = new StringBuilder();

                for (int k = 0; k < charLine.Length; k++)
                {
                    //kets[i].Pine.Top = k;
                    //kets[i].Pine.Bottom = lines.Length - k;
                    kets[i].Ket.index = index++;
                    kets[i].Ket.value = charLine[k];
                    //index
                    //sb.Append(kets[i].ToString()).Append(kets[i].Ket.ToString());
                    sb.Append("[");
                    sb.Append(kets[i].Ket.value.ToString());      sb.Append(":");
                    sb.Append(kets[i].Ket.Ascii);
                    sb.Append("]");
                    sb.Append(" ");
                }
                sb.AppendLine();

                Write(sb.ToString());
            }
        }
        public class Kets
        {
            int[] Corner { get; set; }
            int Index { get; set; }
        }
        //columns
        public class Pine
        {
            public int Top { get; set; }
            public int Bottom { get; set; }
        }
        /// <summary>
        ///now is from the left, mind the reverse from bottom
        /// </summary>
        public class Line
        {

            public int Left { get; set; }
            public int Right { get; set; }

            public Ket Ket { get; set; } = new Ket();
            public override string ToString()
            {
                var list = new StringBuilder();
           //     list.Append("L:").Append(Left);
                //  list.Append("E:").Append(End);

                return list.ToString();
            }
        }
        public class Ket
        {
            //唯一index
            public int index { get; set; }
            public char value { get; set; }
            //宽度 int index
            public int Ascii { get { return (int)value; } }
            public byte Byte { get { return (byte)value; } }
            public string Hex { get { return ((byte)Ascii).ToString("x"); } }
            public string Binary { get { return Convert.ToString(((byte)Ascii), 2); } }

            public override string ToString()
            {
                var list = new StringBuilder();
                //list.Append("P:").Append(Top);
                ////   list.Append("U:").Append(Aup);
                //list.Append("Aup:").Append(Bottom);

                //char
                //list.Append(kets[i].Ketpine.value);
                //ascii
                // list.Append(kets[i].Ketpine.Ascii);
                //byte
                 list.Append((byte)Ascii);               
                //hex
                //  list.Append(((byte)kets[i].Ketpine.Ascii).ToString("x"));
                //binary
                //  list.Append(Convert.ToString(((byte)kets[i].Ketpine.Ascii),2));
                return list.ToString();

            }
        }

    }
}
