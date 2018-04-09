
using System;
using System.Linq;
using System.Reflection;

public class HarvestingFieldsTest
{
    public static void Main()
    {
        Type type = Type.GetType("HarvestingFields");
        FieldInfo[] allFields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        string command;

        while ((command = Console.ReadLine()) != "HARVEST")
        {
            ExecuteCommand(command, allFields);
        }
    }

    private static void ExecuteCommand(string command, FieldInfo[] allFields)
    {
        FieldInfo[] filteredFields;
        switch (command)
        {
            case "public":
                filteredFields = allFields.Where(f => f.IsPublic).ToArray();
                break;

            case "private":
                filteredFields = allFields.Where(f => f.IsPrivate).ToArray();
                break;

            case "protected":
                filteredFields = allFields.Where(f => f.IsFamily).ToArray();
                break;

            case "all":
                filteredFields = allFields;
                break;

            default:
                throw new InvalidOperationException("Unknown command!");
        }

        PrintFilteredFields(filteredFields);
    }

    private static void PrintFilteredFields(FieldInfo[] filteredFields)
    {
        foreach (var field in filteredFields)
        {
            if (field.Attributes.ToString() == "Family")
            {
                Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
            }
            else
            {
                Console.WriteLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
            }
        }
    }
}

