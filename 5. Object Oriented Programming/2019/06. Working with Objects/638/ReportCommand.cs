using _638.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _638
{
    class ReportCommand : Command
    {
        public ReportCommand(string[] data, IRepository repo, IUnitFactory fatory):base(data,repo,fatory)
        {

        }
        public override string Execute()
        {
            string output = base.Repository.Statistics;
            return output;
        }
    }
}
