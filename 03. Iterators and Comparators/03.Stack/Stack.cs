using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Stack<T> : IEnumerable<T>
{
    private readonly List<T> list;
    private int listCount;

    public Stack()
    {
        this.list = new List<T>();
        this.listCount = this.list.Count;
    }
    
    public void Push(params T[] listItems)
    {
        foreach (var item in listItems)
        {
            this.list.Add(item);
        }
    }

    public void Pop()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("No elements");
        }
        this.list.RemoveAt(list.Count - 1);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this.list.Count -1; i >= 0; i--)
            yield return this.list[i];

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

