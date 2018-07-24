using System;
using System.Collections;
using System.Collections.Generic;

[AttributeUsage (AttributeTargets.Class, Inherited = false)]
public class CustomAttribute : System.Attribute {
    string name;

    public CustomAttribute(string name)
    {
        this.name = name;
    }
}
