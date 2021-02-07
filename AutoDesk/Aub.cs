
using System;

[AttributeUsage(AttributeTargets.Class |
AttributeTargets.Constructor |
AttributeTargets.Field |
AttributeTargets.Method |
AttributeTargets.Property,
AllowMultiple = true)]

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