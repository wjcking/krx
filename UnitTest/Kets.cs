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
        public void utf()
        {
            //string utf8String = "骞垮憡涓戦椈";

            //// Create two different encodings.
            //Encoding utf8 = Encoding.UTF8;
            //Encoding defaultCode = Encoding.Default;

            //// Convert the string into a byte[].
            //byte[] utf8Bytes = default.GetBytes(utf8String);

            //// Perform the conversion from one encoding to the other.
            //byte[] defaultBytes = Encoding.Convert(utf8, defaultCode, utf8Bytes);

            //// Convert the new byte[] into a char[] and then into a string.
            //// This is a slightly different approach to converting to illustrate
            //// the use of GetCharCount/GetChars.
            //char[] defaultChars = new char[defaultCode.GetCharCount(defaultBytes, 0, defaultBytes.Length)];
            //defaultCode.GetChars(defaultBytes, 0, defaultBytes.Length, defaultChars, 0);
            //string defaultString = new string(defaultChars);

            //// Display the strings created before and after the conversion.
            //Console.WriteLine("Original string: {0}", utf8String);
            //Console.WriteLine("Ascii converted string: {0}", defaultString);

            ////或者如下：
            //byte[] buffer1 = Encoding.Default.GetBytes(utf8String);
            //byte[] buffer2 = Encoding.Convert(Encoding.UTF8, Encoding.Default, buffer1, 0, buffer1.Length);
            //string strBuffer = Encoding.Default.GetString(buffer2, 0, buffer2.Length);
        }

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
        [TestMethod]
        public void Testkets()
        {
            var lines = File.ReadAllLines(@"C:\Users\Administrator\Desktop\keynote.txt");
           // var lines = File.ReadAllLines(@"f:\VSProjects\AngelWolf\Rastera\asnic\rastera\ketself.html");
            //Each of characters,0b hex 
            int index = 0;
            int columns = 0;
            var length = 0;
            char[] charArray;
          
            Ket[,] kets;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Length > length)
                {
                    length = lines[i].Length;
                    columns = i;
                }

            //    charArray = lines[i].ToCharArray();
            }

            kets = new Ket[columns, length];
            //instead of charArray.Length,for the sake of tables
            var sb = new StringBuilder();
            for (int i = 0; i < columns; i++)
            {         
                 charArray = lines[i].ToCharArray();
                for (int k = 0; k < length; k++)
                {
                    kets[i, k] = new Ket();
                    kets[i, k].Line = k;
                    kets[i, k].End = length - k;
                    kets[i, k].Pine = i;
                    kets[i, k].Aup = columns - k;
                    kets[i, k].index = index++;
                    kets[i, k].Ascii = 0;
                    //length > charLength
                    if (k < charArray.Length && !(k > charArray.Length))
                        kets[i, k].value = charArray[k];
                    else
                        kets[i, k].value = Char.MinValue;
                    sb.Append(kets[i, k].value);
                }
            }
        }
        /// <summary>
        /// Solid.flat.Odin(paper finger):
        /// dot feeling click
        /// Kolor&more
        /// line like tinywhat
        /// </summary>
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
            public int Line { get; set; }
            public int End { get; set; }
            //char[] 1 to N subscript
            public int Pine { get; set; }
            public int Aup { get; set; }

            public int index { get; set; }
            public ushort Ascii { get; set; }
            public char value { get; set; }
        }

 

    }
}
