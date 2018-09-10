using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _84
{
    public class JobEventArgs : EventArgs
    {
        public JobEventArgs(Job job)
        {
            this.job = job;
        }
        public Job job { get; set; }
    }
}
