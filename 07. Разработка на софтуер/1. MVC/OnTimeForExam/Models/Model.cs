namespace OnTimeForExam.Models
{
    public class Model
    {
        private DateTime startTime;
        private DateTime arrivalTime;

        public int startHour;

        public int StartHour
        {
            get { return startHour; }
            set
            {
                if (value >= 0 && value <= 23)
                {
                    startHour = value;
                }
                else
                {
                    throw new Exception("Incorrect Start Hour Input");
                }
            }
        }

        private int startMinutes;

        public int StartMinutes
        {
            get { return startMinutes; }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    startMinutes = value;
                }
                else
                {
                    throw new Exception("Incorrect Start Minutes Input");
                }
            }
        }

        private int arrivalHour;
        public int ArrivalHour
        {
            get { return arrivalHour; }
            set
            {
                if (value >= 0 && value <= 23)
                {
                    arrivalHour = value;
                }
                else
                {
                    throw new Exception("Incorrect Arrival Hour Input");
                }
            }
        }

        private int arrivalMinutes;
        public int ArrivalMinutes
        {
            get { return arrivalMinutes; }
            set
            {
                if (value >= 0 && value <= 59)
                {
                    arrivalMinutes = value;
                }
                else
                {
                    throw new Exception("Incorrect Arrival Minutes Input");
                }
            }
        }

        public Model(int sh, int sm, int ah, int am)
        {
            StartHour = sh;
            StartMinutes = sm;
            ArrivalHour = ah;
            ArrivalMinutes = am;

            startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Month, sh, sm, 0);
            arrivalTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Month, ah, am, 0);
        }

        public string Calculate()
        {
            string result = String.Empty;
            if (DateTime.Compare(arrivalTime, startTime) <= 0)
            {
                int diffHours = (startTime - arrivalTime).Hours;
                int diffMinuts = (startTime - arrivalTime).Minutes;
                if (diffMinuts <= 30 && diffHours == 0)
                {
                    return "On time\n";
                }
                else
                {
                    result += "Early\n";
                }
                var append = String.Empty;
                if (diffMinuts < 10) append = "0";
                if (diffMinuts > 0 && diffHours == 0)
                {
                    result += $"{append}{diffMinuts} minutes before the start";
                }
                else result += $"{diffHours}:{append}{diffMinuts} hours before the start";
            }
            else
            {
                result += "Late\n";
                int diffHours = (startTime - arrivalTime).Hours;
                int diffMinuts = (startTime - arrivalTime).Minutes;

                var append = String.Empty;
                if (diffMinuts < 10) append = "0";
                if (diffMinuts > 0 && diffHours == 0)
                {
                    result += $"{append}{diffMinuts} minutes after  the start";
                }
                else result += $"{diffHours}:{append}{diffMinuts} hours after  the start";
            }
            return result;
        }
    }
}
