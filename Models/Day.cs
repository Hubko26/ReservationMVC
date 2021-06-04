using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReservationMVC.Enum;

namespace ReservationMVC.Models
{
    public class Day
    {
        Days dayName;
        Dictionary<int, bool> hourOccupied = new Dictionary<int, bool>();

        public Day()
        {

        }

        public Day(Dictionary<int, bool> hourOccupied, Days dayName)
        {
            HourOccupied = hourOccupied;
            DayName = dayName;
        }

        public Dictionary<int, bool> HourOccupied { get => hourOccupied; set => hourOccupied = value; }
        public Days DayName { get => dayName; set => dayName = value; }

        public bool DayIsValid()
        {
            return HourOccupied.Any(x => x.Value == false);
        }

        public override bool Equals(object obj)
        {
            return obj is Day day &&
                   EqualityComparer<Dictionary<int, bool>>.Default.Equals(HourOccupied, day.hourOccupied) &&
                   DayName == day.DayName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(HourOccupied, DayName);
        }
    }
}
