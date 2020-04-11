using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam.Views
{
    class Display
    {
        public int hourOfExam { get; set; }
        public int minuteOfExam { get; set; }
        public int hourOfArrival { get; set; }
        public int minuteOfArrival { get; set; }
        public string Result { get; set; }

        public Display()
        {
            this.hourOfExam = 0;
            this.minuteOfExam = 0;
            this.hourOfArrival = 0;
            this.minuteOfArrival = 0;
            this.Result = string.Empty;
            GetValues();
        }

        private void GetValues()
        {
            hourOfExam = int.Parse(Console.ReadLine());
            minuteOfExam = int.Parse(Console.ReadLine());
            hourOfArrival = int.Parse(Console.ReadLine());
            minuteOfArrival = int.Parse(Console.ReadLine());
        }

        public void PrintValues()
        {
            Console.WriteLine(Result);
        }
    }
}
