using System;
using System.Linq;

public class CommandInterpreter
{
    private CustomList<string> list;

    public CommandInterpreter()
    {
        this.list = new CustomList<string>();
    }

    public void ProcessInput()
    {
        string inputLine;

        while ((inputLine = Console.ReadLine()) != "END")
        {
            var inputArgs = inputLine.Split().ToList();

            var command = inputArgs[0];
            inputArgs.Remove(inputArgs.First());

            switch (command)
            {
                case "Add":
                    this.list.Add(inputArgs[0]);
                    break;

                case "Remove":
                    this.list.Remove(int.Parse(inputArgs[0]));
                    break;

                case "Contains":
                    Console.WriteLine(this.list.Contains(inputArgs[0]));
                    break;

                case "Swap":
                    this.list.Swap(int.Parse(inputArgs[0]), int.Parse(inputArgs[1]));
                    break;

                case "Greater":
                    Console.WriteLine(this.list.CountGreaterThan(inputArgs[0]));
                    break;

                case "Max":
                    Console.WriteLine(this.list.Max());
                    break;

                case "Min":
                    Console.WriteLine(this.list.Min());
                    break;

                case "Print":
                    foreach (var item in this.list)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case "Sort":
                    this.list.Sort();
                    break;

                default:
                    break;
            }
        }
    }
}
