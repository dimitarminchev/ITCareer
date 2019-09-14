using _638.Contracts;
using _638.Core.Factories;
using _638.Data;
using _638.Models.Units;
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
            //IUnit unit = UnitFactory.CreateUnit(unitType);
            string output = base.Repository.RemoveUnit(unitType);
            return output;
        }
    }
}
