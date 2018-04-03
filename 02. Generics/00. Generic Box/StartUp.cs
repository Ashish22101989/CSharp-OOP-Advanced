using System;

class StartUp
{
    static void Main(string[] args)
    {
        var box = new Box<string>("Misho");

        Console.WriteLine(box);
    }
}

