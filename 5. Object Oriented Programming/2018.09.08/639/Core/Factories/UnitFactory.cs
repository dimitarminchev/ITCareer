namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;
    using System.Reflection;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            Type unit = Type.GetType("_03BarracksFactory.Models.Units." + unitType);
            IUnit unitInstance =(IUnit) Activator.CreateInstance(unit);
            return unitInstance;
        }
    }
}
