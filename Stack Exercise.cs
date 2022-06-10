using System;
using System.Collections.Generic;


namespace CSharpIntermediate;


class Program
{
    static void Main(String[] args)
    {
        var stack = new Stack();

        int mini = 1;
        int max = 5;

        for (int i = mini; i < max; i++)
            stack.Push(i);

       

        for     (int i = mini; i < max; ++i)
            Console.WriteLine(stack.Pop());

        Console.ReadLine();
    }
}

public class Stack

{
    private readonly List<object> _list = new List<object>();

    public void Push(Object obj)
    {
        if (obj == null)
            throw new InvalidOperationException("You can't add a null object to the stack");

        _list.Add(obj);
     
    }

    public object Pop()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException("There isn't no element in the stack yet. ");

        var index = _list.Count - 1;    
       var toReturn = _list[index];

      
        _list.RemoveAt(index);

        return (toReturn);
    }

    public void clear ()
    {
        _list.Clear();
    }
}
