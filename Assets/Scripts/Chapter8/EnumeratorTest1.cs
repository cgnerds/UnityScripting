using System;
using System.Collections.Generic;

public class EnumeratorTest {
    static void Main()
    {
        foreach (string s in GetEnumerableTest())
        {
            Console.WriteLine(s);
        }
    }

    static IEnumerable<string> GetEnumerableTest()
    {
        yield return "begin";

        for(int i=0; i<10; i++)
        {
            yield return i.ToString();
        }

        yield return "end";
    }
}
