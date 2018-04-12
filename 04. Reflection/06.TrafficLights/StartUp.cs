using System;
using System.Collections.Generic;

namespace _06.TrafficLights
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] inputLights = Console.ReadLine().Split();

            List<ITrafficLight> trafficLights = new List<ITrafficLight>();

            foreach (var light in inputLights)
            {
                var trafficLight = new TrafficLight(light);
                trafficLights.Add(trafficLight);
            }

            int numberOfSwitches = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSwitches; i++)
            {
                foreach (var trafficLight in trafficLights)
                {
                    trafficLight.Cycle();
                }

                Console.WriteLine(string.Join(" ", trafficLights));
            }
        }
    }
}
