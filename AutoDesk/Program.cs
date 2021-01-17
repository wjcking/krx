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
        /// <summary>
        /// 1.分析问题 
        /// 2.效率
        /// 3.Metrix~Mytrik
        /// 4.来萨克 德米切利 迪米特里 Dimitry Dmtry
        /// 5.凯美瑞 莱昂 Komet compile
        /// 
        ///1. struct在栈里面，class在堆里面。
        ///2. struct不支持继承。
        ///3. struct 不能有参数为空的构造函数,如果提供了构造函数，必须把所有的变量全都初始化一遍
        ///4. 不能直接初始化变量。
        ///5. struct是值类型，class是引用类型，这是最本质区别。
        ///6. struct轻量级，class重量级。
        ///7. 当涉及数组操作时，struct效率高，涉及collection操作时，class效率高
        /// </summary>
        struct DingNew
        {
           public static int mydix =0;

            //New^ding(多个好似 复制多个）
            public int Eidix;           
            //public string Index;// = "Index-t"; 
            public DingNew(String s)
            {
                Eidix = 1;
                //eidix
            }
            public void PrintN()
            {
                Console.Write(string.Format("New{0} My:{1}", Eidix++, mydix++));
            }

            
            /**************************************/


            //Ding~new(new inside 好似包起来)
            
            public static   int  Eydix=  0;
            public static void Pirnt() { Console.Write(String.Format("Ding{0} My:{1}", Eydix++, mydix++)); }
            //ding extrame
            //readonly
            //const

        }
        struct Ding
        {
            public static readonly object O = "o";
            public static void Pirnt() { Console.Write(String.Format("Ding", "")); }
        }
        struct New
        {
            public int Eidix;
            public New(String s)
            {
                Eidix = 1;
                //eidix
            }
            public void PrintN()
            {
                Console.Write(string.Format("New{0}", Eidix++));
            }
        }
        static void Main(string[] args)
        {
            //   Console.BackgroundColor = ConsoleColor.Magenta;
            Console.ForegroundColor = ConsoleColor.Yellow;

            //  var cyt =new Cybert();
            DingNew dingNeo;
            dingNeo = new DingNew();
            for (int i = 0; i < 12; i++)
            {
                DingNew.Pirnt();
                dingNeo.PrintN();
                Console.WriteLine();
            } 
            Chs.Lin
            Console.Read();
        }
    }
}
