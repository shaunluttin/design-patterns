using System;

namespace Behavioral.Observer
{
    public class ClockTimer : Subject
    {
        private System.Threading.Timer _timer;

        public ClockTimer()
        {
            _timer = new System.Threading.Timer(
                (e) => Notify(),
                null,
                System.TimeSpan.Zero,
                System.TimeSpan.FromSeconds(1));
        }

        public void Dispose() 
        {
            _timer.Dispose();
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