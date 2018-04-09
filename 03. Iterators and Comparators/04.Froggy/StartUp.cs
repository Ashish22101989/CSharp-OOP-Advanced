using System;
using System.Linq;

namespace _04.Froggy
{
    class StartUp
    {
        public static void Main()
        {
            var stoneNumbers = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var lake = new Lake(stoneNumbers);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
