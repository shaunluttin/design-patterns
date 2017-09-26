using System;

namespace Behavioral.Observer
{
    public class ClockTimer : Subject
    {
        public ClockTimer()
        {
            var timer = new System.Threading.Timer(
                (e) => Notify(),
                null,
                System.TimeSpan.Zero,
                System.TimeSpan.FromSeconds(1));
        }

        internal int GetHour()
        {
            return DateTime.Now.Hour;
        }

        internal int GetMinute()
        {
            return DateTime.Now.Minute;
        }

        internal int GetSecond()
        {
            return DateTime.Now.Second;
        }
    }
}