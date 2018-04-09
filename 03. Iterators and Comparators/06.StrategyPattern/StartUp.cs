using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {
        var nameComparator = new NameComparator();
        var ageComparator = new AgeComparator();

        var personSet1 = new SortedSet<Person>(nameComparator);
        var personSet2 = new SortedSet<Person>(ageComparator);

        int numberOfPersons = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPersons; i++)
        {
            var personInput = Console.ReadLine().Split();
            var name = personInput[0];
            var age = int.Parse(personInput[1]);

            var person = new Person(name, age);

            personSet1.Add(person);
            personSet2.Add(person);
        }

        PrintPersonSet(personSet1);
        PrintPersonSet(personSet2);
    }

    private static void PrintPersonSet(SortedSet<Person> personSet)
    {
        foreach (var person in personSet)
        {
            Console.WriteLine(person);
        }
    }
}

