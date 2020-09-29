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
        public enum SymbolType : ushort
        {
            Character = 1,
            Separator = 2,
            Link = 3,
            Bracket =4
        }
        [TestMethod]
        public void hex()
        {
            //老人 常用 筛选 到 规矩
            //习惯
            //自定义分隔符优先 链接符 括号
            //IDictionary<int, char> KetSymbols = new Dictionary<int, char>();


            // IList<char[]> Dynamic;

            var text = "劳拉：[直觉？这是我[们唯一]的线索。壁画上说还会有[更多的灾]难。要帮助他们，]最好的方法就是阻止它，阻止圣三一".ToCharArray();

            int i = 0;
            int e = text.Length - 1;
         //   var symbols = new Symbols[text.Length];
            while (i < text.Length)
            {
                Write("Id:" + i);
                Write("Start:" + text[i++]);
                WriteLine(" End:" + text[e--]);
                //Symbols[SymbolType.BracketLeft]
             //   WriteLine[Symbols.GetSymbols(]
            }

        }
        public static IList<Symbol> Symbols
        {
            get
            {
//                40(左括号（left parenthesis）	left parenthesis
//   41)   右括号（right parenthesis）	right parenthesis
//91[左方括号（left square bracket）	left square bracket
//92	\	反斜线（backslash）	backslash
//93]   右方括号（right square bracket）	right square bracket

                IList<Symbol> dict = new Symbol[6];
 
            //KetSymbols.Add(  
            //dict.Add(new Symbol(',', SymbolType.Normal, 0));
            //dict.Add(new Symbol(':', SymbolType.Normal, 0));
            //dict.Add(new Symbol('，', SymbolType.Normal, 0));
            //dict.Add(new Symbol('：', SymbolType.Normal, 0));
            //dict.Add(new Symbol('|', SymbolType.Normal, 0));
            //dict.Add(new Symbol('[', SymbolType.BracketLeft, 0));
            //dict.Add(new Symbol(']', SymbolType.BracketRight, 0));
            

            return dict;
            }
        }
        public class Symbol
        {
            //    public int Number = 0;
            public char Value;
            public SymbolType SymbolType;
            public int Piroity;
            public int Start;
            public int End;
            public Symbol(char value, SymbolType type, int piroity)
            {
                Value = value;
                SymbolType = type;
                Piroity = piroity;
            }

        }
    }
}
