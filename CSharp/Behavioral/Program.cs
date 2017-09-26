using System;

namespace Behavioral
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var program = new Program();

            program.WithObserver();

            // prevent program exit so we can view the observer's timer.
            System.Diagnostics.Process.GetCurrentProcess().WaitForExit();
        }

        private void WithObserver()
        {
            var timer = new Observer.ClockTimer();
            var analogClock = new Observer.AnalogClock(timer);
            var digitalClock = new Observer.DigitalClock(timer);
        }
    }
}
