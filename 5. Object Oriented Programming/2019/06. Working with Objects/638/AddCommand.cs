using _638.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _638
{
    class AddCommand : Command
    {
        public AddCommand(string[] data, IRepository repo, IUnitFactory fatory) : base(data, repo, fatory)
        {

        }
        public override string Execute()
        {
            string unitType = base.Data[1];
            IUnit unitToAdd = base.UnitFactory.CreateUnit(unitType);
            base.Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";
            return output;
        }
    }
}
