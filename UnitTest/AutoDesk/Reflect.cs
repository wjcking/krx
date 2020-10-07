using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static System.Console;
namespace UnitTest.AutoDesk
{
    [TestClass]
    public class Reflect
    {
        [TestMethod]
        public void PrintStatic()
        {
            var typeDirectory = typeof(Directory);
            var typeFile = typeof(File);
            var typeFileInfo = typeof(FileInfo);
            //index = i
            ///Directory.CreateDirectory
            ///Directory.Move
            ///Directory.Delete
            ///Directory.GetFiles 
            //
            ///File.Exists
            ///File.Move
            ///File.Create
            ///File.Delete
            ///
            //var methods = types.GetMethods();
            //methods[0].IsStatic
          //  var bindingFlags =System.Reflection.BindingFlags.Static;
            var staticMethod = typeDirectory.GetMethod("GetCreationTimeUtc");
            var delete = typeDirectory.GetMethod("GetFiles", new Type[2] { typeof(string), typeof(bool) });
            var staticParameters = staticMethod.GetParameters();

    //    [19]: {System.String[] GetFiles(System.String)}
    //    [20]: {System.String[] GetFiles(System.String, System.String)}
    //    [21]: {System.String[] GetFiles(System.String, System.String, System.IO.SearchOption)}
    //    [22]: {System.String[] GetDirectories(System.String)}
    //    [23]: {System.String[] GetDirectories(System.String, System.String)}
    //    [24]: {System.String[] GetDirectories(System.String, System.String, System.IO.SearchOption)}
    //    [25]: {System.String[] GetFileSystemEntries(System.String)}
    //    [26]: {System.String[] GetFileSystemEntries(System.String, System.String)}
    //    [27]: {System.String[] GetFileSystemEntries(System.String, System.String, System.IO.SearchOption)}
            var returned = staticMethod.Invoke(null, new object[1] { @"C:\Users\Administrator\Desktop\out.html" });
        }
        public class Predictor
        {
            public Type PredicType { get; set; }
            public IList<MethodInfo> MethodList { get; set; }
            //public object this[string command]
            //{
            //    get
            //    {            //private static readonly IList<Type> list;
            //        //  staticMethod.Invoke(null, new object[1] { @"C:\Users\Administrator\Desktop\out.html" });
            //        return null;
            //    }
            //}
        }
        [TestMethod]
        public void Print()
        {
            ////反射获取 命名空间+类名
            //string className = "UnitTest.AutoDesk.ClassSample";

            //传递参数
            Object[] paras = new Object[] { "我的", "电脑" };
            var t = typeof(ClassSample);
            //object obj = Activator.CreateInstance(t);
            var obj = new ClassSample();
            try
            {

                //直接调用
                //MethodInfo method = t.GetMethod("test24");
                //method.Invoke(obj, paras);

                MethodInfo[] info = t.GetMethods();
                for (int i = 0; i < info.Length; i++)
                {
                    var md = info[i];
                    //方法名 
                    //参数集合
                    ParameterInfo[] paramInfos = md.GetParameters();
                    //方法名相同且参数个数一样
                    if (md.Name == "test1" && paramInfos.Length == paras.Length)
                    {

                        md.Invoke(obj, paras);
                        //Write(paramInfos[0].Name);
                        //Write(paramInfos[0].Name);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }

    public class ClassSample
    {
        public void Static(string para1)
        {
            Console.WriteLine("静态函数名{1} {0}", para1);
        }
        public void Static2(string para1)
        {
            Console.WriteLine("静态函数名{1} {0}", para1);
        }

        public void test1(string para1)
        {
            Console.WriteLine("函数名{1} {0}", para1);
        }

        public void test2(string para1, string para2)
        {
            Console.WriteLine("函数名 {0} {1}", para1, para2);
        }

        public void test3(string para1, string para2)
        {
            Console.WriteLine("函数名 {0} {1}", para1, para2);
        }
    }
}
