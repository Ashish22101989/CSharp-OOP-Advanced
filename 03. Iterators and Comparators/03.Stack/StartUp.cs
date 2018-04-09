using System;
using System.Linq;

namespace _03.Stack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                try
                {
                    var inputArgs = input.Split();
                    var command = inputArgs[0];

                    switch (command)
                    {
                        case "Push":
                            var pushParams = input
                                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(e => e.TrimEnd(','))
                                    .Skip(1)
                                    .ToArray();
                            stack.Push(pushParams);
                            break;
                        case "Pop":
                            stack.Pop();
                            break;
                        default:
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
