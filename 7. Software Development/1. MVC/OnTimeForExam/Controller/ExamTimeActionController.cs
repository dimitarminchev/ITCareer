using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnTimeForExam.Model;
using OnTimeForExam.Views;
namespace OnTimeForExam.Controller
{
    class ExamTimeActionController
    {
        ExamTime examTime;
        Display display;

        public ExamTimeActionController()
        {
            this.display = new Display();
            this.examTime = new ExamTime
            (
                  display.hourOfExam,
                  display.minuteOfExam, 
                  display.hourOfArrival,
                  display.minuteOfArrival
            );

            display.Result = examTime.GetResult();
            display.PrintValues();
        }
    }
}
