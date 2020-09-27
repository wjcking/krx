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
        public const ushort AsciiSpace = 32;

        protected static char[] Next = "\r\n".ToCharArray();
        /*  At the end of organised the ket array, it will add top and bottom
        *   Further discusstion:handle faimly kid metric
        * C P P P P P P   C
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
        public void PrintketStruct()
        {
            var doc = new HtmlDocument();

            doc.Load(@"C:\Users\Administrator\Desktop\keynote.txt", Encoding.GetEncoding("utf-8"));
            if (string.Empty == doc.Text)
                return;
            var xpath = "//head[@id='header']";
            var value = doc.DocumentNode.SelectNodes(xpath).First().InnerHtml;

            var htmlTexts = value.Split(Next, StringSplitOptions.RemoveEmptyEntries);
            int number = 0;
            char[] charLine;
            //遍历每一行 求出最大ket count 
            int volume = 0;
            Ketline[] ketlines = new Ketline[htmlTexts.Length];

            for (int i = 0; i < ketlines.Length; i++)
            {
                ketlines[i] = new Ketline();


                charLine = htmlTexts[i].ToCharArray();
                ketlines[i].KetChars = new List<KetChar>(charLine.Length);
                //是否记住下标
                volume = charLine.Length > volume ? charLine.Length : volume++;
                for (int k = 0; k < charLine.Length; k++)
                {

                    ketlines[i].KetChars.Add(new KetChar());
                    ketlines[i].KetChars[k].Number = number++;
                    ketlines[i].KetChars[k].Value = charLine[k];
                    ketlines[i].SpaceLength = charLine[k];
                }
            }

            //**************print ********************

            for (int i = 0; i < ketlines.Length; i++)
            {
                for (int k = ketlines[i].KetChars.Count; k < volume; k++)
                {
                    ketlines[i].KetChars.Add(new KetChar());
                    ketlines[i].KetChars[k].Value = '$';
                }
            }
            var sb = new StringBuilder();

            for (int i = 0; i < ketlines.Length; i++)
            {
                for (int k = 0; k < ketlines[i].KetChars.Count; k++)
                    sb.Append(ketlines[i].KetChars[k].Value);
                sb.AppendLine();
            }
            //vertically check for Kansai and more
            for (int k = 0; k < volume; k++)
            {
                for (int i = 0; i < ketlines.Length; i++)
                    sb.Append(ketlines[i].KetChars[k].Value);
                //     
                sb.AppendLine();
            }

            Write(sb.ToString());
            //  File.WriteAllText(@"C:\Users\Administrator\Desktop\pad.txt", sb.ToString());
        }
        /// <summary>
        ///top 
        //main
        //bottom
        //At the end of organised the ket array, it will add top and bottom
        //Further discusstion:handle faimly kid metric
        /// </summary>
        public class KetStruct
        {

            private static IDictionary<string, ushort> Indexes;
            private Ketline[] Ketlines = null;
            public KetStruct(int length)
            {
                Ketlines = new Ketline[length];
            }
            public RectCorner Corner { get; set; }
            /// <summary>
            /// Lines length for html text
            /// "5" the maximum volume Chinese Ascii 5 byte
            /// organize the format of pad or html table
            /// </summary>
            public int Length { get; set; }
            //main
            //int Index { get; set; } = 1;
            // int Lines { get; set; }
            int Columns { get; set; }
            IList<int[][]> Function { get; set; }


        }

        /// <summary>
        ///now is from the left, mind the reverse from bottom
        /// </summary>
        public class Ketline
        {
            private bool isSpaced = false;
            private ushort spaceLength = 0;

            public IList<KetChar> KetChars { get; set; }
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

                    else if (value == AsciiSpace)
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
        public class KetChar
        {

            //唯一index
            public int Number { get; set; }
            public char Value { get; set; }
            //宽度 length
            public int Ascii { get { return (int)Value; } }
            public byte Byte { get { return (byte)Value; } }
            public string Hex { get { return ((byte)Ascii).ToString("x"); } }
            public string Binary { get { return Convert.ToString(((byte)Ascii), 2); } }

            //    public int VolumnPad { get {}
            public int VolumnLeft { get { return 5 - Ascii.ToString().Length; } }
            public KetChar this[int index]
            {
                get { return this.Number == index ? this : new KetChar() { Number = -1 }; }
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
