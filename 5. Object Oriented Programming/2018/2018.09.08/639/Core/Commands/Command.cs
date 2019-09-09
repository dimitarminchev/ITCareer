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


        public Command(string[] data)
        {
            this.Data = data;
        }
        public abstract string Execute();
    }
}
