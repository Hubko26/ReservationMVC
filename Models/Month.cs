using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReservationMVC.Enum;

namespace ReservationMVC.Models
{
    public class Month
    {
        int numberOfDays;
        Days firstDayOfMonth;
        Dictionary<int, Day> daysOfMonth;
        public Month()
        {

        }
        public Month(int numberOfDays, Days firstDayOfMonth, Dictionary<int, Day> daysOfMonth)
        {
            NumberOfDays = numberOfDays;
            FirstDayOfMonth = firstDayOfMonth;
            this.DaysOfMonth = daysOfMonth;
        }

        public Days FirstDayOfMonth { get => firstDayOfMonth; set => firstDayOfMonth = value; }
        public int NumberOfDays { get => numberOfDays; set => numberOfDays = value; }
        public Dictionary<int, Day> DaysOfMonth { get => daysOfMonth; set => daysOfMonth = value; }

        public override bool Equals(object obj)
        {
            return obj is Month month &&
                   FirstDayOfMonth == month.FirstDayOfMonth &&
                   NumberOfDays == month.NumberOfDays;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstDayOfMonth, NumberOfDays);
        }
    }
}
