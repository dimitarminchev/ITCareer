using _638.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _638
{
    class RemoveCommand : Command
    {
        public RemoveCommand(string[] data, IRepository repo, IUnitFactory fatory) : base(data, repo, fatory)
        {

        }
        public override string Execute()
        {
            string unitType = base.Data[1];
            IUnit unitToAdd = base.UnitFactory(unitType);
            base.Repository.RemoveUnit(unit);
            string output = unitType + " retired!";
            return output;
            return output;
        }
    }
}
