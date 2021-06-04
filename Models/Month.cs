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

        public Month(int numberOfDays, Days firstDayOfMonth)
        {
            this.numberOfDays = numberOfDays;
            this.FirstDayOfMonth = firstDayOfMonth;
        }

        public Days FirstDayOfMonth { get => firstDayOfMonth; set => firstDayOfMonth = value; }
        public int NumberOfDays { get => numberOfDays; set => numberOfDays = value; }

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
