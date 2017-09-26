using System;

namespace Behavioral
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var program = new Program();

            program.WithObserver();
            program.WithStrategy();
            program.WithTemplateMethod();

            // prevent program exit so we can view the observer's timer.
            System.Diagnostics.Process.GetCurrentProcess().WaitForExit();
        }

        private void WithTemplateMethod()
        {
            var myView = new TemplateMethod.MyView();
            myView.Display();
        }

        private void WithStrategy()
        {
            var quick = new Strategy.Composition(new Strategy.SimpleCompositor());
            var slick = new Strategy.Composition(new Strategy.TeXCompositor());
            var iconic = new Strategy.Composition(new Strategy.ArrayCompositor());

            quick.Repair();
            slick.Repair();
            iconic.Repair();
        }

        private void WithObserver()
        {
            var timer = new Observer.ClockTimer();
            var analogClock = new Observer.AnalogClock(timer);
            var digitalClock = new Observer.DigitalClock(timer);
        }
    }
}
