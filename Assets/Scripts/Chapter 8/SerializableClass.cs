using System;
using System.Collections;

[Serializable]
public class SerializableClass{
    public string name;
    public int age;
    public bool isHero;

    public SerializableClass(string name, int age, bool isHero)
    {
        this.name = name;
        this.age = age;
        this.isHero = isHero;
    }
}
