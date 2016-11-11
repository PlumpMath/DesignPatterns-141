using System;
using System.Collections.Generic;
using System.Threading;

namespace LazyInitialization
{
    public class Customer
    {
        private List<string> orders;

        public Customer()
        {
            CustomerName = "John";
        }

        public string CustomerName { get; set; }

        private List<string> LoadOrders()
        {
            var orders = new List<string>();
            orders.Add("o1");
            Thread.Sleep(1000);
            orders.Add("o2");
            Thread.Sleep(1000);
            orders.Add("o3");
            Thread.Sleep(1000);
            return orders;
        }

        public void PrintOrders()
        {
            if (orders == null)
            {
                orders = LoadOrders();
            }
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }
    }
}