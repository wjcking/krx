using System;
using System.Linq;
using HtmlAgilityPack;
using static System.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class htmlAglity
    {
        [TestMethod]
        public void loadfile()
        {
            var doc = new HtmlDocument();
            doc.Load(@"F:\VSProjects\AngelWolf\AngelLayout\anti-docx.html");

            // With XPath 
            var id = "compiled";
            var xpath = "//div[@id='"+id+"']";
            var value = doc.DocumentNode. SelectNodes(xpath).First().InnerHtml;
            Write(value);

            // With LINQ 
            //var nodes = doc.DocumentNode.Descendants("input")
            // .Select(y => y.Descendants()
            // .Where(x => x.Attributes["class"].Value == "box"))
            // .ToList();
        }
        [TestMethod]
        public void loadurl()
        {
       
            var url = "https://www.126.com";
            var web = new HtmlWeb();
            var doc = web.Load(url);
            // With XPath 
            var value = doc.DocumentNode.SelectNodes("//head")[0].InnerHtml;
            Write(value);
        }
    }
}
