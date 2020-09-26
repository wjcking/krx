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
using System.Collections.Generic;

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
        public void ketstruct()
        {
            var doc = new HtmlDocument();

            doc.Load(@"C:\Users\Administrator\Desktop\keynote.txt", Encoding.GetEncoding("utf-8"));

            var xpath = "//head[@id='header']";
            var value = doc.DocumentNode.SelectNodes(xpath).First().InnerHtml;
            if (null == value)
                return;
            var htmlTexts = value.Split(Next, StringSplitOptions.RemoveEmptyEntries);
            int index = 0;
            char[] charLine;
            Ketline[] linekets  = new Ketline[htmlTexts.Length];
            for (int i = 0; i < htmlTexts.Length; i++)
            {
                linekets[i] = new Ketline();

                charLine = htmlTexts[i].ToCharArray();
                linekets[i].Ket  = new   Ket[charLine.Length];
                for (int k = 0; k < charLine.Length; k++)
                {

                    linekets[i].Ket[k] = new Ket();
                    linekets[i].Ket[k].index = index++;
                    linekets[i].Ket[k].value = charLine[k];
                    linekets[i].SpaceLength = charLine[k];
                }
               // sb.AppendLine();

             //   Write(sb.ToString());
            }
        }
        /// <summary>
        ///top 
        //main
        //bottom
        //At the end of organised the ket array, it will add top and bottom
        /// </summary>
        public class KetStruct
        {
            
            private static IDictionary<string,ushort> Indexes;
            private Ketline[] Ketlines = null;
            public KetStruct(int length)
            {
               
               Ketlines =new Ketline[length + 2];
             
            }
            public RectCorner Corner { get; set; }
            //main
            //int Index { get; set; } = 1;
           // int Lines { get; set; }
            int Columns { get; set; }
            IList<short[][]> Function { get;set;}


        }

        /// <summary>
        ///now is from the left, mind the reverse from bottom
        /// </summary>
        public class Ketline
        {
            private bool isSpaced = false;
            private ushort spaceLength = 0;

            public IList<Ket> Ket { get; set; }
            public ushort SpaceLength
            {
                get
                {
                    return spaceLength;
                }
                set
                {
                    if (isSpaced)
                        return;

                    else if (value == 32)
                        spaceLength++;
                    else
                        isSpaced = true;
                }
            }

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
            //宽度 length
            public int Ascii { get { return (int)value; } }
            public byte Byte { get { return (byte)value; } }
            public string Hex { get { return ((byte)Ascii).ToString("x"); } }
            public string Binary { get { return Convert.ToString(((byte)Ascii), 2); } }

            public Ket this[int index]
            {
                get { return this.index == index ? this : new Ket() {index=-1 }; }
            }
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
