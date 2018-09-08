using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03BarracksFactory.Contracts;

namespace _6._3._7.Core.Commands
{
    class FightCommand : Command
    {
        public FightCommand(string[] data, IRepository r, IUnitFactory uF ) : base(data)
        {
        }

        public override string Execute()
        {
            Environment.Exit(0);
            return null;
        }
    }
}
