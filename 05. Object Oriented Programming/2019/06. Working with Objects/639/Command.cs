using _369.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _369.Core.Commands
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
