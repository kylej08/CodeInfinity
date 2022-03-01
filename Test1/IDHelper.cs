using System;

namespace Test1
{
    public static class IDHelper
    {
        public static bool IsValidId(string id)
        {
            return id.Length == 13 && (id[10] == '0' || id[10] == '1');
        }


        public static bool IsDOBComparisonEqual(string id, DateTime date)
        {
            return date.Year == GetYearForId(id)
                    && date.Month == GetMonthForId(id)
                    && date.Day == GetDayForId(id);
        }

        private static int GetYearForId(string id)
        {
            return int.Parse("19" + id.Substring(0, 2));
        }

        private static int GetMonthForId(string id)
        {
            return int.Parse(id.Substring(2, 2));
        }

        private static int GetDayForId(string id)
        {
            return int.Parse(id.Substring(4, 2));
        }

    }
}
