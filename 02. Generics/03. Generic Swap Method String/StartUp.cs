using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
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

        var swapIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int firstIndex = swapIndexes[0];
        int secondIndex = swapIndexes[1];

        Swapper.Swap(listOfBoxes, firstIndex, secondIndex);

        foreach (var box in listOfBoxes)
        {
            Console.WriteLine(box);
        }
    }
}
