using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Console;
namespace Preditor
{
    [TestClass]
    public class Hex
    {
        [TestMethod]
        public void  hex()
        {
            // hex("12321321"); 
            //GetByte("\tasdf");
            //GetByte("\t阿斯蒂芬");
            //GetByte("اللغة العربية#اللغة العربية");
            //GetByte("※卍卐Ψ♫♬♭♩♪♯♮⌒");
            //GetByte("¶∮‖€ぁあぃいぅうぇえぉおか");
            //GetByte("ぁあぃいぅうぇえぉおか");
            //var b = hex("ⅠⅡⅢⅣⅤⅥⅦⅧⅨⅩⅪⅫ");
            WriteLine("-------------------");
            //result; =  Binary("10011011000010100010110010111011100110110101110110011011011111010010");
            //            ASCII byte[] 转string：
            //string str = System.Text.Encoding.Default.GetString(b);
            //WriteLine(str);
            //           string转ASCII byte[]：

            //byte[] byteArray = System.Text.Encoding.ASCII.GetBytes(str);
            var value = "<!DOCTYPE html>";
            //3c21444f43545950452068746d6c3e
            //3c21444f43545950452068746d6c3e
            var list = Hexget(value, HexType.Binary);

            foreach (var ket in list)
                Write(ket);
 
            //var ascii = System.Text.Encoding.ASCII.GetBytes(value);
            //WriteLine(ascii);
        }
        public enum HexType
        {
            Binary = 0,
            Octal,
            Hexadecimal,
            Decimal,
            Ascii
        }
        public string GetAscii(string value)
        {
            var bytes = GetBytes(value);
            return Encoding.ASCII.GetString(bytes);
        }
        public byte[] GetBytes(string value, Encoding encoding = null)
        {
            Encoding encode = encoding == null ? Encoding.Default : encoding;
            return encode.GetBytes(value);
        }
        public IList<string> Hexget(string value, HexType hexType = HexType.Hexadecimal, Encoding encoding = null)
        {
            var bytes = GetBytes(value, encoding);
            IList<string> kets = new List<string>();
            foreach (byte b in bytes)
            {
                if (hexType == HexType.Binary)
                    kets.Add(Convert.ToString(b, 2));
                else if (hexType == HexType.Hexadecimal)
                    kets.Add(Convert.ToString(b.ToString("x")));
                else if (hexType == HexType.Octal)
                    kets.Add(Convert.ToString(b.ToString("8")));
                //else if (hexType == HexType.Octal)
                //    Encoding.ASCII.GetString(bytes);
            }
            return kets;
        }
        //public byte[] GetByteStringArray(string value)
        //{

        //  //  byte[] b = encode.GetBytes(value);
        //    //   WriteLine("string:" + value.Length + "byte:" + b.Length);

        //    //for (int i = 0; i < b.Length; i++)
        //    //{
        //    //    var binary = Convert.ToString(b[i], 2);
        //    //    // Console.Write("{0}", binary);
        //    //    Console.Write(b[i].ToString("x") + " ");
        //    //}
        //    //     WriteLine();
        //    return b;
        //}

        //private string GetBinary(string str)
        //{
        //    System.Text.RegularExpressions.CaptureCollection cs = System.Text.RegularExpressions.Regex.Match(str, @"([01]{8})+").Groups[1].Captures;
        //    byte[] data = new byte[cs.Count];
        //    for (int i = 0; i < cs.Count; i++)
        //    {
        //        data[i] = Convert.ToByte(cs[i].Value, 2);
        //    }
        //    return Encoding.Unicode.GetString(data, 0, data.Length);
        //}

    }
}
