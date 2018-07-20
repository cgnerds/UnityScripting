using System;

[CustomAttribute ("ChenClass")]
class ChenClass{
    public static void Main()
    {
        ChenClass c = new ChenClass();
    }

    public ChenClass()
    {
        // 判断ChenClass类是否应用了CustomAttribute特性，如果是则打印出ChenClass
        if(this.GetType().IsDefined(typeof(CustomAttribute), false))
        {
            System.Console.WriteLine("ChenClass");
        }
    }
}
