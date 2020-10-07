using System.Collections.Generic;
using static System.Console;

namespace Asnic.Preditor
{
    public class Hex
    {
        public static IDictionary<ushort, Symbol> GetSymbols()
        {
            //40(左括号（left Parenthesis）	left parenthesis
            //41)   右括号（right Parenthesis）	right parenthesis
            //91[左方括号（left SquareBracket）	left square bracket

            //93]   右方括号（right SquareBracket）	right square bracket

            IDictionary<ushort, Symbol> dict = new Dictionary<ushort, Symbol>();

            dict.Add(1, new Symbol(Constant.BracketLeft, SymbolType.Bracket,0));
            dict.Add(2, new Symbol(Constant.BracketRight, SymbolType.Bracket, 0));
            dict.Add(3, new Symbol(Constant.ParentLeft, SymbolType.Bracket,0));
            dict.Add(4, new Symbol(Constant.ParentRight, SymbolType.Bracket, 0));
            //dict.Add(new Symbol('，', SymbolType.Character, 0));
            //dict.Add(new Symbol('：', SymbolType.Character, 0));
            //dict.Add(new Symbol('|', SymbolType.Separator, 0));
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
            public SideKorner SideKorner;
            
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
