using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer
{
    public interface ISubject
    {
        void AddObserver(IObserver observer);

    }
    public class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public Subject()
        {

        }
        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        private void SomethingHappened(int newValue)
        {
            _observers.ForEach(x => x.Notified(newValue));

            foreach (var observer in _observers)
            {
                observer.Notified(newValue);
            }
        }
        private int mySubject;

        public int MuSubject
        {
            get { return mySubject; }
            set
            {
                mySubject = value;
                SomethingHappened(value);
            }
        }

    }
}
