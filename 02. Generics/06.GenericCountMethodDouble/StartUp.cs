using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        int inputCount = int.Parse(Console.ReadLine());

        IList<Box<double>> listOfBoxes = new List<Box<double>>();

        for (int i = 0; i < inputCount; i++)
        {
            var input = double.Parse(Console.ReadLine());
            listOfBoxes.Add(new Box<double>(input));
        }

        var referenceValue = double.Parse(Console.ReadLine());

        Console.WriteLine(listOfBoxes.First().Compare(listOfBoxes,referenceValue));
    }
}

