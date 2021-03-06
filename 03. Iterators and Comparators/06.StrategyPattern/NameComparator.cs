﻿using System;
using System.Collections.Generic;
using System.Text;

public class NameComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        var result = x.Name.Length.CompareTo(y.Name.Length);

        if (result == 0)
        {
            result = x.Name.ToLower()[0].CompareTo(y.Name.ToLower()[0]);
        }

        return result;
    }
}
