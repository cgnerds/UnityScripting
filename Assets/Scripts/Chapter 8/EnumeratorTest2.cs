using System;
using System.Collections.Generic;

public class EnumeratorTest2 {

    static IEnumerable<int> TestStateChange()
    {
        Console.WriteLine("----我TestStateChange是第一行代码");
        Console.WriteLine("----我是第一个 yield return 前的代码");
        yield return 1;
        Console.WriteLine("----我是第一个 yield return 后的代码");
        Console.WriteLine("----我是第二个 yield return 前的代码");
        yield return 2;
        Console.WriteLine("----我是第二个 yield return 后的代码");
    }


    static void Main()
    {
        Console.WriteLine("调用TestStateChange");
        IEnumerable<int> iteratorable = TestStateChange();
        Console.WriteLine("调用GetEnumerator");
        IEnumerator<int> iterator = iteratorable.GetEnumerator();
        Console.WriteLine("调用MoveNext()");
        bool hasNext = iterator.MoveNext();
        Console.WriteLine("是否有数据={0}; Current={1}", hasNext, iterator.Current);
        Console.WriteLine("第二次调用MoveNext");
        hasNext = iterator.MoveNext();
        Console.WriteLine("是否有数据={0}; Current={1}", hasNext, iterator.Current);
        Console.WriteLine("第三次调用MoveNext");
        hasNext = iterator.MoveNext();
        Console.WriteLine("是否有数据={0}", hasNext);
    }
}
