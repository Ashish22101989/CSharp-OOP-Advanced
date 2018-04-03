using System;
using System.Collections.Generic;
using System.Text;

public class Box<T>
{
    private T inputValue;

    public Box(T inputValue)
    {
        this.inputValue = inputValue;
    }

    public override string ToString()
    {
        return $"{this.inputValue.GetType().FullName}: {this.inputValue}";
    }
}

