using System;
using static System.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asnic;
using Asnic.Preditor;

namespace AutoTest
{
    [TestClass]
    public class AutoTest
    {
        [TestMethod]
        public void PrintFiles()
        {
            try
            {
                Files.Execute("N a");
                Files.Execute("Move b\\f.html a\\f.html");
                Files.Execute("D d\\");
                Files.Execute("l d\\ketself 'content'");
                Files.Execute("阿斯蒂芬斯蒂芬");

                //  WriteLine(StartPath);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Brandkets
        /// </summary>
        [TestMethod]
        public void PrintDirect()
        {
            
        }
        /// <summary>
        /// Brandkets
        /// </summary>
        [TestMethod]
        public void PrintBracket()
        {
            //老人 常用 筛选 到 规矩
            //习惯
            //自定义分隔符优先 链接符 括号
            var symbols = Hex.GetSymbols();
            var text = "{System.String[] GetFileSystemEntries(System.String, System.String, System.IO.SearchOption)}";
            //k(end.On Saturda(y mor[ni(ng, I) played the pian]o and learned English.Saturday after
            var clone = text.Clone().ToString();

            int start = 0;
            int end = 0;

            start = clone.IndexOf(symbols[3].Value)+1;
            clone = clone.Substring(start);
            end = clone.LastIndexOf(symbols[4].Value);
            clone = clone.Substring(0, end);
            WriteLine(clone);

        }
    }
}
