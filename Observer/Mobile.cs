using System;

namespace Observer
{
    public class Mobile : IObserver
    {

        public void Update(Stock stock)
        {
            Console.WriteLine(string.Format("Mobile : Update from stock:{0} price {1}", stock.Name, stock.Price));
        }
    }
}