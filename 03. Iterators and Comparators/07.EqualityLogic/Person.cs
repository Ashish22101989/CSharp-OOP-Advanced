using System;
using System.Collections.Generic;
using System.Text;

public class Person : IComparable<Person>
{
    public string Name { get; private set; }

    public int Age { get; private set; }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    
    public int CompareTo(Person other)
    {
        var result = this.Name.CompareTo(other.Name);

        if (result == 0)
        {
            result = this.Age.CompareTo(other.Age);
        }

        return result;
    }

    public override bool Equals(object obj)
    {
        if (obj is Person other)
        {
            return this.Name == other.Name && this.Age == other.Age;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return this.Name.GetHashCode() + this.Name.GetHashCode();
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Age}";
    }
}
