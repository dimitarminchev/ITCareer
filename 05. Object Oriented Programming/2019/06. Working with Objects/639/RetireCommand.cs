using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _369.Contracts;

namespace _369.Core.Commands
{
    class RetireCommand : Command
    {
        private IRepository repository;

        protected IRepository Repository
        {
            get { return repository; }
            set { repository = value; }
        }

        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data)
        {
            this.Repository = repository;
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            try
            {
                this.Repository.RemoveUnit(unitType);
                return $"{unitType} retired!";
            }
            catch(Exception exception)
            {
                throw new ArgumentException("No such units in repository.", exception);
            }
        }
    }
}
