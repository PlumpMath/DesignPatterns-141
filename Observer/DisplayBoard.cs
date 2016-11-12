using System;

namespace Observer
{
    public class DisplayBoard : IObserver
    {

        public void Update(Stock stock)
        {
            Console.WriteLine(string.Format("DisplayBoard : Update from stock:{0} price {1}", stock.Name,stock.Price));
        }
    }
}