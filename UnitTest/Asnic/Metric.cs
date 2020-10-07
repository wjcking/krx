
/*career 
 * Ket-seo-F
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
*
*/
/// <summary>
/// Hxwall 
/// </summary>
public enum Axis
{
    Center = 0,
    Angle = 1,
    StickSide = 2 //related to the WhichAction
}

public enum SymbolType : ushort
{
    Character = 1,
    Separator = 2,
    Link = 3,
    Bracket = 4,
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
/// HxW Witch 添加了一个all、美化
/// 接触一点金去就是Penetrate 点面 出 用
/// Stick不接触好像贴着
/// </summary>
public enum ActionBehavior
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
    dimension = 3
}

