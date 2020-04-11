using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes.Model
{
    class Pool
    {
        private double poolCapacity;
        public double PoolCapacity
        {
            get { return poolCapacity; }
            set { poolCapacity = value; }
        }

        private double pipe1;
        public double Pipe1
        {
            get { return pipe1; }
            set { pipe1 = value; }
        }

        private double pipe2;
        public double Pipe2
        {
            get { return pipe2; }
            set { pipe2 = value; }
        }

        private double hoursOfAbsence;
        public double HoursOfAbsence
        {
            get { return hoursOfAbsence; }
            set { hoursOfAbsence = value; }
        }

        public Pool(double poolCapacity, double pipe1, double pipe2, double hoursOfAbsence)
        {
            this.poolCapacity = poolCapacity;
            this.pipe1 = pipe1;
            this.pipe2 = pipe2;
            this.hoursOfAbsence = hoursOfAbsence;
        }

        public string GetResult()
        {
            string result = string.Empty;
            double workOfPipe1 = Math.Round(pipe1 * hoursOfAbsence);
            double workOfPipe2 = Math.Round(pipe2 * hoursOfAbsence);
            double fullness = Math.Round((workOfPipe1 + workOfPipe2) / (poolCapacity / 100));
            double overflow = Math.Round((workOfPipe1 + workOfPipe2) - poolCapacity);
            double wholeWorkOfPipe1 = Math.Round(workOfPipe1 / ((workOfPipe1 + workOfPipe2) / 100));
            double wholeWorkOfPipe2 = Math.Round(workOfPipe2 / ((workOfPipe1 + workOfPipe2) / 100));

            if(poolCapacity > (workOfPipe1 + workOfPipe2))
            {
                result += $"The pool is {fullness}% full." +
                          $" Pipe 1: {wholeWorkOfPipe1}%" +
                          $" Pipe 2: {wholeWorkOfPipe2}%.";
            }
            else
            {
                result += $"For {hoursOfAbsence} hours the pool overflows with {overflow} liters.";
            }
            return result;
        }

    }
}
