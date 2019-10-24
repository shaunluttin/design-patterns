using System;

namespace Behavioral.Observer
{
    public class DigitalClock : Observer, IWidget
    {
        private ClockTimer _subject;

        public DigitalClock(ClockTimer s)
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
            var second = _subject.GetSecond();
            Console.WriteLine($"D {hour}-{minute}-{second}");
        }
    }
}