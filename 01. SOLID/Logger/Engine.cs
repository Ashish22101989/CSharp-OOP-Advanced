using Logger.Models.Factories;
using Logger.Models.Interfaces;
using System;

namespace Logger
{
    public class Engine
    {
        private ILogger logger;
        private ErrorFactory errorFactory;

        public Engine(ILogger logger, ErrorFactory errorFactory)
        {
            this.logger = logger;
            this.errorFactory = errorFactory;
        }

        public void Run()
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] errorArgs = input.Split('|');
                string level = errorArgs[0];
                string dateTime = errorArgs[1];
                string message = errorArgs[2];

                //to check sequence of string in CreateError method
                IError error = errorFactory.CreateError(dateTime, level, message);
                this.logger.Log(error);
            }

            Console.WriteLine("Logger Info");

            foreach (var appender in this.logger.Appenders)
            {
                Console.WriteLine(appender);
            }
        }
    }
}
