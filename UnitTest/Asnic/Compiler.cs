
using System.Text;
/* Ket-seo-F
 * is duplicate
 *   LeverStick
 *   position
 * 3.14 absolute diamond
 *      unparall diamond
 *  Rotate,
 *      roll,
 *      spin,//cos
 *  turn, //by whom
 *      whirl,
 *      Encircle
 *      spiral
 *Transcolor
*//// <summary>
/// Hxwall 
/// </summary>
public enum Axis
{
    center = 0,
    Angle = 1,
    StickSide = 2 //related to the WhichAction
}
/// <summary>
///     1 2 3
/// C 1 0 0 0 C
///   2 0 0 0 1
///   3 0 0 0
/// C 4 0 0 0 C
/// 类似于传真引线
/// </summary>
public enum SideKorner : ushort
{
    Top = 0,
    Left = 1,
    Right = 2,
    Bottom = 3
}
/// <summary>
/// 
/// </summary>


/// <summary>
/// HxW Witch 添加了一个all、美化
/// 接触一点金去就是Penetrate 点面 出 用
/// Stick不接触好像贴着
/// </summary>
public enum WhichAction
{
    Drag = 0,
    Push = 1,
    //which how metric 
    Stick = 2
}
/// <summary>
/// Creal.Tetris not just Facial 
/// kaetseolf
/// Odin
/// Kolor
/// HxW
/// </summary>
public enum SolidMetric
{
    flat = 0,
    metric =1
}

/// <summary>
/// 
/// </summary>
public enum EarthMetrik
{
    dot = 0,//?.anti- anti~
    line = 1,//atlair
    //connector=2,
    /// <summary>
    /// 三维立体 四维 atscup
    /// </summary>
    dimension = 4
}

namespace Compiler
{
    public class Compiler
    {
        public class Basic
        {
            Encoding encoding = Encoding.Default;
            ushort Language = 0;
            string text;
            char[] Spliter;
            char[] Bracket;
        }
      
    }
}