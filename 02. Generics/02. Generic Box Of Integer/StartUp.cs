using System;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        int inputCount = int.Parse(Console.ReadLine());

        IList<Box<int>> listOfBoxes = new List<Box<int>>();

        for (int i = 0; i < inputCount; i++)
        {
            var input = int.Parse(Console.ReadLine());
            listOfBoxes.Add(new Box<int>(input));
        }

        foreach (var box in listOfBoxes)
        {
            Console.WriteLine(box);
        }
    }
}

