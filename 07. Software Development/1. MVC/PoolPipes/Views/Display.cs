using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes.Views
{
    class Display
    {
        public double poolCapacity { get; set; }
        public double pipe1 { get; set; }
        public double pipe2 { get; set; }
        public double hoursOfAbsence { get; set; }
        public string result { get; set; }

        public Display()
        {
            this.poolCapacity = 0;
            this.pipe1 = 0;
            this.pipe2 = 0;
            this.hoursOfAbsence = 0;
            this.result = string.Empty;
            GetValues();
        }

        public void GetValues()
        {
            poolCapacity = double.Parse(Console.ReadLine());
            pipe1 = double.Parse(Console.ReadLine());
            pipe2 = double.Parse(Console.ReadLine());
            hoursOfAbsence = double.Parse(Console.ReadLine());
        }

        public void PrintValues()
        {
            Console.WriteLine(result);
        }
    }
}
