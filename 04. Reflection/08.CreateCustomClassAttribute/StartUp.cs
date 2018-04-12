using System;
using System.Linq;

[Info("Pesho",3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]
public class StartUp
{
    static void Main(string[] args)
    {
        Type classType = typeof(StartUp);

        var attribute = (InfoAttribute)classType.GetCustomAttributes(true).First();

        string input;

        while ((input = Console.ReadLine()) != "END")
        {
            attribute.Print(input);
        }
    }
}

