namespace CodeCoverage.Lib
{
    public class Helper
    {
        private static DateTime _epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static double GetUnixEpoch(DateTime dateTime)
        {
            return dateTime.Subtract(_epoch).TotalSeconds;
        }

        public static DateTime GetDateTimeFromUnixEpoch(double value)
        {
            return _epoch.AddSeconds(value);
        }

        public static long GetYYYMMDD(DateTime dateTime)
        {
            return (dateTime.Year * 10000) + (dateTime.Month * 100) + dateTime.Day;
        }

        public static bool IsLeapYear(int year)
        {
            // A leap year is evenly divisible by 4 with the following exceptions:
            // If evenly divisible by 100 - false
            // If evenly divisible by 400 - true

            if (year <= 0) throw new ArgumentOutOfRangeException(nameof(year));

            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;

            return (year % 4 == 0);
        }
    }
}