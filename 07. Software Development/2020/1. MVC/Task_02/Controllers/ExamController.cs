using System;
using Task_02.Models;
using Task_02.Views;

namespace Task_02.Controllers
{
    class ExamController
    {
        private Display display;
        private Exam exam;

        public ExamController()
        {
            display = new Display();
            while (exam is null)
            {
                try
                {
                    display.Input();
                    exam = new Exam
                    (
                        display.StartHour, 
                        display.StartMinutes, 
                        display.ArrivalHour, 
                        display.ArrivalMinutes
                    );
                }
                catch (Exception e) 
                { 
                    display.Response = e.Message; 
                    display.ShowResponse(); 
                }
            }
            display.Response = exam.Calculate();
            display.ShowResponse();
        }
    }
}
