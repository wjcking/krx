using System;
using System.Collections.Generic;
using System.Text;
/*array index matric artfod erick archtecture
  1 dynamical prefix suffix 
     type fonk kind rank indexet
  2 orginal structed 
3 build each or combine above
*/
class erick
{
    static short //index
        a, b, c, d,
        na, nb, nc, nd;
    static short
       /* L1*/ my, name1, syx_is1, jacky, asc_kma1, her, name2, are, mary,
        /*L2*/   your, age, syx_is2, thrteen, asc_kma2;
    short[] erics = new short[4] 
        { a, b, c, d };
    short[] karacts = new short[14]
    { 
    /* L1.Len9*/ my,name1, syx_is1, jacky, asc_kma1,her, name2, are, mary,
	 /*L2.Len5*/ your, age, syx_is2, thrteen,asc_kma2
    };
    //Line:12737
    //Row:255
    //1 最长字符宽度 固定 为空不缺0 如果用List 则结构 效率 牵连
    //2 回车换行 获取最大长度 
    // word 选项 每行最多个数
    // excel 最长宽度
    short[,] lind = new short[2, 9] //lineMax,rowMax
    {
        /*L1.Count9*/    {my,name1, syx_is1, jacky, asc_kma1,her, name2, are, mary},
       /*L2.Count5*/ {  your, age, syx_is2, thrteen,asc_kma2,0,0,0,0 }
    };
    //List<short> land = new List<short>(
}

struct pixels
{
    /*
    MFC :
    * dc.SetPixel(x, y, RGB(255, 0, 0));
    win32 API
    :SetPixel(hdc, x, y, RGB(255, 0, 0));
    */
}