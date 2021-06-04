using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReservationMVC.Models;
using ReservationMVC.Enum;

namespace ReservationMVC.Test
{
    public static class TestData
    {
        public static Day GenerateDay()
        {
            var day = new Day();
            day.HourOccupied = new Dictionary<int, bool> ();

            for (int i = 0; i < 24; i++)
            {
                day.HourOccupied.Add(i + 1, true);
            }

            return day;
        }
        public static Month GenerateMonth()
        {
            var testMonth = new Month();
            testMonth.NumberOfDays = 30;
            testMonth.FirstDayOfMonth = Days.Tuesday;
            testMonth.DaysOfMonth = new Dictionary<int, Day>();

            for (int i = 0; i < testMonth.NumberOfDays; i++)
            {
                var day = GenerateDay();
                day.DayName = testMonth.FirstDayOfMonth + i;
                testMonth.DaysOfMonth.Add(i + 1, day);
            }

            return testMonth;
        }
    }
}
