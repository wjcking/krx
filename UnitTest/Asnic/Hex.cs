using System.Collections.Generic;
using static System.Console;
namespace Preditor
{
    public class Hex
    {
        public enum SymbolType : ushort
        {
            Character = 1,
            Separator = 2,
            Link = 3,
            BracketLeft = 4,
            BracketRight = 4
        }
        public void hex()
        {
            //老人 常用 筛选 到 规矩
            //习惯
            //自定义分隔符优先 链接符 括号
                var symbols =  GetSymbols();
            //IDictionary<int, char> KetSymbols = new Dictionary<int, char>();
           //  var text  = "劳拉：[直觉？这是我[们唯一]的线索。壁画上说还会有[更多的灾]难。要帮助他们，]最好的方法就是阻止它，阻止圣三一";
            var  text = "I had a ve[ry bu[sy week(end.On Saturda(y mor[ni(ng,I) played the pian]o and learned English.Saturday after)noon,";
                        //k(end.On Saturda(y mor[ni(ng, I) played the pian]o and learned English.Saturday after
                        //k(end.On Saturda(y mor[ni(ng, I
                        //k(end.On Saturda(y mor[ni(ng, I
            var clone = text.Clone().ToString();

            int start = 0;
            int end = 0;
            //  var st = text.Split(symbols[3].Value);
            //for (int i=0; i<st.Length; i++)
            // {
            //     WriteLine(st[i]);
            // }
            //   st = text.Split(symbols[4].Value);
            // for (int i = 0; i < st.Length; i++)
            // {
            //     WriteLine(st[i]);
            // }

            start = clone.IndexOf(symbols[3].Value)-1 ;
                clone = clone.Substring(start);
                end = clone.LastIndexOf(symbols[4].Value);
                clone = clone.Substring(0, end);
                WriteLine(clone);

            start = clone.IndexOf(symbols[3].Value)-1;
            clone = clone.Substring(start);
            end = clone.LastIndexOf(symbols[4].Value);
            WriteLine(clone.Substring(0, end));


            start = clone.IndexOf(symbols[3].Value) - 1;
            clone = clone.Substring(start);
            end = clone.LastIndexOf(symbols[4].Value);
            WriteLine(clone.Substring(0, end));

        }
        public void handle(string a)
        {

        }
        public   IDictionary<ushort, Symbol> GetSymbols()
        {
             
//40(左括号（left Parenthesis）	left parenthesis
//41)   右括号（right Parenthesis）	right parenthesis
//91[左方括号（left SquareBracket）	left square bracket

//93]   右方括号（right SquareBracket）	right square bracket

                IDictionary<ushort,Symbol> dict = new Dictionary<ushort, Symbol>();


                dict.Add(1,new Symbol('[', SymbolType.BracketLeft, 0));
                dict.Add(2,new Symbol(']', SymbolType.BracketRight, 0));
            dict.Add(3, new Symbol('(', SymbolType.BracketLeft, 0));
            dict.Add(4, new Symbol(')', SymbolType.BracketRight, 0));
            //dict.Add(new Symbol('，', SymbolType.Normal, 0));
            //dict.Add(new Symbol('：', SymbolType.Normal, 0));
            //dict.Add(new Symbol('|', SymbolType.Normal, 0));
            //dict.Add(new Symbol('[', SymbolType.BracketLeft, 0));
            //dict.Add(new Symbol(']', SymbolType.BracketRight, 0));


            return dict;
            
        }
        public class Symbol
        {
            public bool IsMatched = false;
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
