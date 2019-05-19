using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer
{
    public interface IObserver
    {
        void Notified(int newValue);
    }
    public class Observer : IObserver
    {
        public Observer(ISubject subject)
        {
            subject.AddObserver(this);
        }
        public void Notified(int newValue)
        {
            Console.WriteLine(newValue);
            //whatever we're observing will call this method when something happens
        }
    }
}
