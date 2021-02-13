using System;
using Task02.Model;
using Task02.Views;

namespace Task02.Controllers
{
    public class ExamController
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