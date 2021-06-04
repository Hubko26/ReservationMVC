using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReservationMVC.Enum;

namespace ReservationMVC.Models
{
    public class Day
    {
        bool isValidDate;
        Days dayName;
        List<Dictionary<int, bool>> hourOccupancy = new List<Dictionary<int, bool>>();

        public Day(List<Dictionary<int, bool>> hourOccupancy, Days dayName, bool isWorkingDay)
        {
            HourOccupancy = hourOccupancy;
            DayName = dayName;
            IsWorkingDay = isWorkingDay;
        }

        public List<Dictionary<int, bool>> HourOccupancy { get => hourOccupancy; set => hourOccupancy = value; }
        public Days DayName { get => dayName; set => dayName = value; }
        public bool IsWorkingDay { get => isValidDate; set => isValidDate = value; }

        public override bool Equals(object obj)
        {
            return obj is Day day &&
                   EqualityComparer<List<Dictionary<int, bool>>>.Default.Equals(HourOccupancy, day.HourOccupancy) &&
                   DayName == day.DayName &&
                   isValidDate == day.isValidDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(HourOccupancy, DayName, IsWorkingDay);
        }
    }
}
