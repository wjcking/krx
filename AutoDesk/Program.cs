using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDesk
{
    using Kit;
    class Program
    {
       
        static void Main(string[] args)
        {
            //   Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Yellow;

            //  var cyt =new Cybert();
            //DingNew dingNeo;
            //dingNeo = new DingNew();
            //for (int i = 0; i < 12; i++)
            //{
            //    DingNew.Pirnt();
            //    dingNeo.PrintN();
            //    Console.WriteLine();
            //} 

            //

            //new Cybert(true).Print();
            //new Cybert(false).Print();
            //var cybert = new Cyper("Milf Nude Photo Longmint Tranny MoviesSearch Search Search Search Recent ...A Foreign Affair international dating service meet Russian women Latin women ");
            // cybert.Print();
            var c =new Cyper();
            c.Value = "v";
               var b = 0b0010_0100;

            var f = 0x1f;
            //var axr = new char[35];
            //axr[byte1] = byte1;
            //axr[0x1F] = axr;

           Console.WriteLine(b.GetType().Name); 
           Console.WriteLine(c.Value); 
           //  Console.WriteLine(axr[0x1F]);
            Console.Read();
        }

    }
}
