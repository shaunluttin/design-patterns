using System;

namespace Behavioral.Observer
{
    public class AnalogClock : Observer, IWidget
    {
        private ClockTimer _subject;

        public AnalogClock(ClockTimer s)
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
            Console.WriteLine($"{hour}:{minute}:{second}");
        }
    }
}