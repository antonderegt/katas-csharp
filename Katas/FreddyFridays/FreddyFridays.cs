using System;

namespace Katas.FreddyFridays
{
    public class FreddyFridays
    {
        public static int FindFridaysThe13thInYear(int year)
        {
            DateTime date = new(year, 1, 13);
            DayOfWeek friday = DayOfWeek.Friday;
            int friday13 = 0;

            while(date.Year == year)
            {
                if(date.DayOfWeek == friday)
                    friday13++;

                date = date.AddMonths(1);
            }

            return friday13;
        }
    }
}
