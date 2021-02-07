
using System;

[AttributeUsage(AttributeTargets.Class |
AttributeTargets.Constructor |
AttributeTargets.Field |
AttributeTargets.Method |
AttributeTargets.Property,
AllowMultiple = true)]
//只有类才可以派生 ，放在结构体上面
public class  tin : System.Attribute
{
 
    /*
     * #Attribute being inherited by tin
     * cxp.rect.vertical= klass1:klass2:klass3:klass4:tin
     * #Object survanlince transform
     * [aub] [aup] [cup] [cub]
     * class1:class2:class3:class4:objant
     */

}