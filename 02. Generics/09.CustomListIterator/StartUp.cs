using System;

public class StartUp
{
    static void Main(string[] args)
    {
        var commandInterpreter = new CommandInterpreter();

        commandInterpreter.ProcessInput();
    }
}

