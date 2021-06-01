namespace Katas.Time
{
    public class TimeFormat
    {
        public static string GetReadableTime(int seconds)
        {
            int hours = 0;
            int minutes = 0;

            if (seconds >= 60 * 60)
            {
                hours = seconds / (60 * 60);
                seconds -= hours * 60 * 60;
            }

            if (seconds >= 60)
            {
                minutes = seconds / 60;
                seconds -= minutes * 60;
            }

            return $"{hours:00}:{minutes:00}:{seconds:00}";
        }
    }
}
