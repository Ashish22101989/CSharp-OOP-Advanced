using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        int inputCount = int.Parse(Console.ReadLine());

        IList<Box<string>> listOfBoxes = new List<Box<string>>();

        for (int i = 0; i < inputCount; i++)
        {
            var input = Console.ReadLine();
            listOfBoxes.Add(new Box<string>(input));
        }

        string referenceValue = Console.ReadLine();

        Console.WriteLine(listOfBoxes.First().Compare(listOfBoxes,referenceValue));
    }
}

