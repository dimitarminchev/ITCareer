using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ObserverDemo
{
    public class Hero : ISubject, IObserver
    {
        private string name;
        private int reward;
        private List<IObserver> observers;        

        public Hero(string name, int reward = 0)
        {
            this.observers = new List<IObserver>();
            this.name = name;
            this.reward = reward;
        }

        public void Register(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this.reward);
            }
        }

        public void Update(int val)
        {
            this.reward = val;
        }
    }
}
