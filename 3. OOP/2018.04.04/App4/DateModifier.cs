using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace App4
{
    class DateModifier
    {
        private DateTime first, second;
        public DateTime First
        {
            get { return first; }
            set { first = value; }
        }
        public DateTime Second
        {
            get { return second; }
            set { second = value; }
        }
        public void InIt(string d1, string d2)
        {
            this.First = DateTime.ParseExact(d1, "yyyy MM dd", CultureInfo.InvariantCulture);
            this.Second = DateTime.ParseExact(d2, "yyyy MM dd", CultureInfo.InvariantCulture);
        }
        public int Difference()
        {
            int days = Math.Abs(this.First.Subtract(this.Second).Days);
            return days;
        }
    }
}
