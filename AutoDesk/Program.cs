using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;

namespace AutoDesk
{

    class Program
    {
        public static void Main(string[] args)
        {
            //  new Codedom().Execute();
            //        Console.ForegroundColor = ConsoleColor.Yellow;

            CSharpCodeProvider p = new CSharpCodeProvider();

            // 设置编译参数
            CompilerParameters options = new CompilerParameters();

            //加入引用的程序集
            options.ReferencedAssemblies.Add("System.dll");
            //options.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            //options.ReferencedAssemblies.Add("System.Drawing.dll");
         //   options.ReferencedAssemblies.Add("System.IO.Directory");

            options.GenerateExecutable = true;                  //是否生成可执行文件，否则就是内存中
                                                                // CompilerOptions 参考地址:https://docs.microsoft.com/zh-cn/dotnet/csharp/language-reference/compiler-options/addmodule-compiler-option
        //    options.CompilerOptions = "-t:winexe";              //非控制台应用程序
        //    options.CompilerOptions += " -win32icon:index.ico"; //设置图标
            options.OutputAssembly = "Evaluator.exe";          //输出exe的名称
            options.MainClass = "Evaluator.Program";          //主运行类
          
            //循环加入资源文件,貌似不支持文件夹,因此多个文件可以自己压缩为zip再加入
            //foreach (var file in this.listBox1.Items)
            //{
            //    options.EmbeddedResources.Add(file.ToString());
            //}

            // 开始编译
            string[] files = new string[]
            {
                    Environment.CurrentDirectory+"\\utc.txt",
                    Environment.CurrentDirectory+"\\Evaluator.cs",
            };
            CompilerResults cr = p.CompileAssemblyFromFile(options, files);

            // 显示编译信息
            if (cr.Errors.Count == 0)
            {
                Console.WriteLine("{0} compiled ok!", cr.CompiledAssembly.Location);
                Console.WriteLine("成功");  
            }
            else
            {
                Console.WriteLine("Complie Error:");
                foreach (CompilerError error in cr.Errors)
                    Console.WriteLine("  {0}", error);
                Console.WriteLine("失败");
            }

            Console.WriteLine("Press Enter key to exit...");
            Console.Read();
        }
    }
}