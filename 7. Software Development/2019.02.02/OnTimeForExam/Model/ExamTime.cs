using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam.Model
{
    class ExamTime
    {
        private int hourOfExam;
        public int HourOfExam
        {
            get { return hourOfExam; }
            set { hourOfExam = value; }
        }

        private int minuteOfExam;
        public int MinuteOfExam
        {
            get { return minuteOfExam; }
            set { minuteOfExam = value; }
        }

        private int hourOfArrival;
        public int HourOfArrival
        {
            get { return hourOfArrival; }
            set { hourOfArrival = value; }
        }

        private int minuteOfArrival;
        public int MinuteOfArrival
        {
            get { return minuteOfArrival; }
            set { minuteOfArrival = value; }
        }

        public ExamTime(int hourOfExam, int minuteOfExam, int hourOfArrival, int minuteOfArrival)
        {
            this.hourOfExam = hourOfExam;
            this.minuteOfExam = minuteOfExam;
            this.hourOfArrival = hourOfArrival;
            this.minuteOfArrival = minuteOfArrival;
        }

        public string GetResult()
        {
            string result = string.Empty;
            int totalTimeOfExam = 60 * hourOfExam + minuteOfExam;
            int totalTimeOfArrival = 60 * hourOfArrival + minuteOfArrival;

            if (totalTimeOfExam < totalTimeOfArrival)
            {
                result += "Late" + Environment.NewLine;
                if (totalTimeOfArrival - totalTimeOfExam < 60)
                {
                    result += $"{totalTimeOfArrival - totalTimeOfExam} minutes after the start";
                }
                else
                {
                    int hours = (totalTimeOfArrival - totalTimeOfExam) / 60;
                    int minutes = (totalTimeOfArrival - totalTimeOfExam) % 60;
                    if (minutes < 10)
                    {
                        result += $"{hours}:0{minutes} hours after the start";
                    }
                    else result += $"{hours}:{minutes} hours after the start";
                }
            }
            else if(totalTimeOfExam - totalTimeOfArrival <= 30 )
            {
                result += "On time";
                if(totalTimeOfExam - totalTimeOfArrival != 0)
                    result += Environment.NewLine + $"{totalTimeOfExam - totalTimeOfArrival} minutes before the start";
            }
            else
            {
                result += "Early" + Environment.NewLine;
                if(totalTimeOfExam - totalTimeOfArrival < 60)
                {
                    result += $"{totalTimeOfExam - totalTimeOfArrival} minutes before the starts";
                }
                else
                {
                    int hours = (totalTimeOfExam - totalTimeOfArrival) / 60;
                    int minutes= (totalTimeOfExam - totalTimeOfArrival) % 60;
                    if (minutes < 10)
                    {
                        result += $"{hours}:0{minutes} hours before the start";
                    }
                    else result += $"{hours}:{minutes} hours before the start";
                }
            }

            return result;
        }
    }
}
