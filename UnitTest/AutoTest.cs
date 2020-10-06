using System;
using static System.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Asnic;
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
                Files.Execute("Move b\\f a\\f");
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
    }
}
