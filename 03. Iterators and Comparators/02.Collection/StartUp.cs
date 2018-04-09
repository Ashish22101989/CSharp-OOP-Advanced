using System;
using System.Linq;

namespace _02.Collection
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var listItems = input.Split().Skip(1).ToArray();
            var collection = new ListyIterator<string>(listItems);

            while ((input = Console.ReadLine()) != "END")
            {
                try
                {
                    switch (input)
                    {
                        case "HasNext":
                            Console.WriteLine(collection.HasNext());
                            break;
                        case "Move":
                            Console.WriteLine(collection.Move());
                            break;
                        case "Print":
                            collection.Print();
                            break;
                        case "PrintAll":
                            collection.PrintAll();
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
        }
    }
}
