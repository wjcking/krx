using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;

namespace AutoDesk
{

    class Program
    {
        public static void Main(string[] args)
        {
            hyb a = new hyb();
            a.ket = '+';
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("阿文" + a.ket);
            Console.Read();
            /*
             * auto test
             */
        }
    }
}