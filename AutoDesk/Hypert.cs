
using System;
using System.Runtime.InteropServices;

namespace AutoDesk
{
    //const type_boolean = "boolean"; const boolean_default = true;
    //const type_number = "number"; const number_default = 0;
    //const type_string = "string"; const string_empty = "";
    //const type_object = "object"; const object_default = null;
    //const type_function = "function"; const function_default = undefined;

    /*
    *   uitlity
    *    logical(+-* I)
     */
    public class Hypert : Kovert
    {
        bool Bool { get; set; }     // 布尔值 True 或 False False
        byte Byte { get; set; }      //8 位无符号整数	0 到 255	0
        char Char { get; set; }     //16 位 Unicode 字符 U +0000 到 U +ffff	'\0'
        decimal Decimal { get; set; }    // 1   28 位精确的十进制值，28-29 有效位数(-7.9 x 1028 到 7.9 x 1028) / 100 到 28	0.0M
        double Double { get; set; }      //64 位双精度浮点型(+/-)5.0 x 10-324 到(+/-)1.7 x 10308	0.0D
        float Float { get; set; }      //32 位单精度浮点型	-3.4 x 1038 到 + 3.4 x 1038	0.0F
        int Int { get; set; }       //	32 位有符号整数类型	-2,147,483,648 到 2,147,483,647	0
        long Long { get; set; }      //64 位有符号整数类型	-9,223,372,036,854,775,808 到 9,223,372,036,854,775,807	0L
        sbyte Sbyte { get; set; }      //8 位有符号整数类型	-128 到 127	0
        short Short { get; set; }      //16 位有符号整数类型	-32,768 到 32,767	0
        uint Uint { get; set; }      //32 位无符号整数类型	0 到 4,294,967,295	0
        ulong Ulong { get; set; }         //64 位无符号整数类型	0 到 18,446,744,073,709,551,615	0
        ushort Ushort { get; set; }              //16 位无符号整数类型	0 到 65,535	0
                                                 //   StructLayoutAttribute  
        
    }


}
