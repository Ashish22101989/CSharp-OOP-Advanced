using System;
using System.Collections.Generic;
using System.Text;

public class Box<T>
    where T : IComparable
{
    public T Value { get; private set; }

    public Box(T inputValue)
    {
        this.Value = inputValue;
    }

    public int Compare(IList<Box<T>> listOfBoxes, T referenceValue)
    {
        int count = 0;

        foreach (var box in listOfBoxes)
        {
            if (box.Value.CompareTo(referenceValue) == 1)
            {
                count++;
            }
        }

        return count;
    }

    public override string ToString()
    {
        return $"{this.Value.GetType().FullName}: {this.Value}";
    }
}

