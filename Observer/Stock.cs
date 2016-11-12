using System;
using System.Collections.Generic;

namespace Observer
{
    public class Stock : IObservable
    {
        private List<IObserver> _observers; 
        public Stock()
        {
            _observers = new List<IObserver>();
        }

        public string Name { get; protected set; }
        public int Price { get; private set; }

        public void SetPrice(int price)
        {
            Price = price;
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            if (observer != null)
            {
                this._observers.Add(observer);
            }
        }

        public void UnregisterObserver(IObserver observer)
        {
            if (observer != null)
            {
                this._observers.Remove(observer);
            }
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}