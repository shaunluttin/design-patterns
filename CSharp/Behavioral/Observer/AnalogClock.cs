using System;

namespace Behavioral.Observer
{
    public class AnalogClock : Observer, Widget
    {
        private ClockTimer _subject;

        protected AnalogClock(ClockTimer s)
        {
            _subject = s;
            _subject.Attach(this);
        }

        public override void Update(Subject theChangedSubject)
        {
            if (theChangedSubject == _subject)
            {
                Draw();
            }
        }

        public void Draw()
        {
            var hour = _subject.GetHour();
            var minute = _subject.GetMinute();
            Console.WriteLine($"{hour} {minute}");
        }
    }
}