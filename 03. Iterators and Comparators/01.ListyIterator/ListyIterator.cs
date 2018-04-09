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

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

