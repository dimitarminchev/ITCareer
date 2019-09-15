using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jobs
            WorkPerformedEventArgs game = new WorkPerformedEventArgs("Gaming", 6);
            WorkPerformedEventArgs develop = new WorkPerformedEventArgs("Developing", 3);

            // Worker
            Worker worker = new Worker();
            worker.WorkPerformed += worker.workPerformed;
            // worker.WorkPerformed += delegate (WorkPerformedEventArgs e) { Console.WriteLine(e.Hours.ToString()); };
            worker.DoWork(game);
            worker.DoWork(develop);           
        }
    }
}
