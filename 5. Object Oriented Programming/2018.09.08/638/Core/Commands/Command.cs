using _03BarracksFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3._7.Core.Commands
{
    abstract class Command : IExecutable
    {
        private string[] data;

        protected string[] Data
        {
            get { return data; }
            set { data = value; }
        }

        private IRepository repository;

        protected IRepository Repository
        {
            get { return repository; }
            set { repository = value; }
        }

        private IUnitFactory unitFactory;

        protected IUnitFactory UnitFactory
        {
            get { return unitFactory; }
            set { unitFactory = value; }
        }

        public Command(string[] data, IRepository repository, IUnitFactory unitFactory)
        {
            this.Data = data;
            this.Repository = repository;
            this.UnitFactory = unitFactory;
        }
        public abstract string Execute();
    }
}
