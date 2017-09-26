using System.Collections.Generic;

namespace Behavioral.Observer
{
    public abstract class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public virtual void Attach(Observer o)
        {
            _observers.Add(o);
        }

        public virtual void Detach(Observer o)
        {
            _observers.Remove(o);
        }

        public virtual void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}