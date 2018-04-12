namespace _03BarracksFactory.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type classType = assembly.GetTypes().FirstOrDefault(t => t.Name == unitType);

            if (classType == null)
            {
                throw new ArgumentException("Invalid Unit Type !");
            }

            if (!typeof(IUnit).IsAssignableFrom(classType))
            {
                throw new ArgumentException($"{unitType} is not a Unit Type!");
            }

            IUnit newUnit = (IUnit)Activator.CreateInstance(classType, new object[] { });
            
            return newUnit;
        }
    }
}
