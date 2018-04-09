using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ListyIterator<T> : IEnumerable<T>
{
    private IReadOnlyList<T> list;
    private int currentIndex;
    private int listCount;


    public ListyIterator(params T[] listItems)
    {
        this.list = listItems;
        this.currentIndex = 0;
        this.listCount = this.list.Count;
    }

    public bool Move()
    {
        if (this.HasNext())
        {
            this.currentIndex++;
            return true;
        }
        return false;
    }

    public void Print()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
        Console.WriteLine(this.list[currentIndex]);
    }

    public bool HasNext()
    {
        if (this.currentIndex < this.listCount - 1)
        {
            return true;
        }

        return false;
    }

    public void PrintAll()
    {
        Console.WriteLine(string.Join(' ', this.list));
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this.list.Count; i++)
            yield return this.list[i];

    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

