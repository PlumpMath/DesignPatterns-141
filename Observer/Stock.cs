using System.Collections.Generic;

namespace Observer
{

    public class Stock : IObservable
    {
        public delegate void StockPriceHandler(Stock stock);

        public event StockPriceHandler OnChange
        {
            add { OnChange += value; }
            remove { throw new System.NotImplementedException(); }
        }


        private readonly List<IObserver> _observers;

        public Stock()
        {
            _observers = new List<IObserver>();
        }

        public string Name { get; protected set; }
        public int Price { get; private set; }
     

        public void RegisterObserver(IObserver observer)
        {
            if (observer != null)
            {
                _observers.Add(observer);
            }
        }

        public void UnregisterObserver(IObserver observer)
        {
            if (observer != null)
            {
                _observers.Remove(observer);
            }
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void SetPrice(int price)
        {
            Price = price;
            NotifyObservers();
           
        }

     
    }
}