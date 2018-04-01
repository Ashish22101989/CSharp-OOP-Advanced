namespace Logger
{
    using Logger.Enums;
    using Logger.Models;
    using Logger.Models.Factories;
    using Logger.Models.Interfaces;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main(string[] args)
        {
            ILogger logger = InitializeLogger();
            ErrorFactory errorFactory = new ErrorFactory();
            Engine engine = new Engine(logger, errorFactory);
            engine.Run();
            
        }

        static ILogger InitializeLogger()
        {
            ICollection<IAppender> appenders = new List<IAppender>();
            LayoutFactory layoutFactory = new LayoutFactory();
            AppenderFactory appenderFactory = new AppenderFactory(layoutFactory);

            int appenderCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < appenderCount; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                string appenderType = inputArgs[0];
                string layoutType = inputArgs[1];
                string errorLevel = "INFO";

                if (inputArgs.Length == 3)
                {
                    errorLevel = inputArgs[2];
                }

                IAppender appender = appenderFactory.CreateAppender(appenderType, errorLevel, layoutType);
                appenders.Add(appender);
            }

            ILogger logger = new Logger(appenders);
            return logger;
        }
    }
}
