using System;
using System.Collections.Generic;
using System.Text;

public class Box<T>
{
    public T Value { get; private set; }

    public Box(T inputValue)
    {
        this.Value = inputValue;
    }

    public override string ToString()
    {
        return $"{this.Value.GetType().FullName}: {this.Value}";
    }
}

