using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var persons = new List<Person>();

        string personInput;

        while ((personInput = Console.ReadLine()) != "END")
        {
            var personArgs = personInput.Split();
            var name = personArgs[0];
            var age = int.Parse(personArgs[1]);
            var town = personArgs[2];

            var person = new Person(name, age, town);
            persons.Add(person);
        }

        var personIndex = int.Parse(Console.ReadLine());

        var personToCompare = persons[personIndex - 1];

        int equalPersonsCount = 0;

        foreach (var person in persons)
        {
            var result = personToCompare.CompareTo(person);

            if (result == 0)
            {
                equalPersonsCount++;
            }
        }

        if (equalPersonsCount == 1)
        {
            Console.WriteLine("No matches");
        }
        else
        {
            Console.WriteLine($"{equalPersonsCount} {persons.Count - equalPersonsCount} {persons.Count}");
        }
    }
}
