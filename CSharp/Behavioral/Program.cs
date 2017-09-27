using System;

namespace Behavioral
{
    public class Program
    {
        private DemoRunner.Runner _runner;

        public Program(DemoRunner.Runner runner)
        {
            _runner = runner;
            _runner.Add("Observer", () => WithTemplateMethod());
            _runner.Add("Strategy", () => WithStrategy());
            _runner.Add("Template Method", () => WithObserver());
            _runner.Start();
        }

        public static void Main(string[] args)
        {
            var program = new Program(new DemoRunner.Runner());
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

            _runner.Stop = () => timer.Dispose();
        }
    }
}
