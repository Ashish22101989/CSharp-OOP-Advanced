namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type type = Type.GetType("P02_BlackBoxInteger.BlackBoxInteger");

            FieldInfo innerValue = type.GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            object instance = Activator.CreateInstance(type, true);

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var commandArgs = input.Split('_');
                var methodName = commandArgs[0];
                var value = int.Parse(commandArgs[1]);

                MethodInfo method = methods.First(m => m.Name == methodName);

                method.Invoke(instance, new object[] { value });

                Console.WriteLine(innerValue.GetValue(instance));
            }
        }
    }
}
