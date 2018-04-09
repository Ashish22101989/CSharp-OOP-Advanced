using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {
        var sorted = new SortedSet<Person>();
        var hash = new HashSet<Person>();

        int numberOfPersons = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPersons; i++)
        {
            var personInput = Console.ReadLine().Split();
            var name = personInput[0];
            var age = int.Parse(personInput[1]);

            var person = new Person(name, age);

            sorted.Add(person);
            hash.Add(person);
        }

        Console.WriteLine(sorted.Count);
        Console.WriteLine(hash.Count);
    }
}

