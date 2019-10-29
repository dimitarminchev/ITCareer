using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _369.Contracts;

namespace _369.Core.Commands
{
    class AddCommand : Command
    {
        private IUnitFactory UnitFactory;
        private IRepository Repository;
        public AddCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data)
        {
            this.UnitFactory = unitFactory;
            this.Repository = repository;
        }

        public override string Execute()
        {
            string unitType = Data[1];
            IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);
            this.Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
