using System;
using System.Threading;

namespace Behavioral.Observer
{
    public class ClockTimer : Subject
    {
        private Timer _timer;

        public ClockTimer()
        {
            _timer = new Timer((s) => Notify(), null, 0, 1000);
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