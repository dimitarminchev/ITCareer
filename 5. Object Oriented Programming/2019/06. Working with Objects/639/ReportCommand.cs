using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _369.Contracts;

namespace _369.Core.Commands
{
    class ReportCommand : Command
    {
        private IRepository repository;

        protected IRepository Repository
        {
            get { return repository; }
            set { repository = value; }
        }

        public ReportCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data)
        {
            this.Repository = repository;
        }

        public override string Execute()
        {
            string output = this.Repository.Statistics;
            return output;
        }
    }
}
