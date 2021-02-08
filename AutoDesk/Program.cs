
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
 
            atb.func();
            Console.Read();
            /*
             * auto test
             */
        }
    }
}
public struct atb
{

    [System.Diagnostics.Conditional("fok")]
    public static void func()
    {
        Console.Write("defined fok");
        Console.Write("defined fok");
    }
}