using System;

namespace LazyInitialization
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Customer Start Read");
            var customer = new Customer();
            Console.WriteLine("Customer Readed");
            Console.ReadLine();

            customer.PrintOrders();
            Console.ReadLine();

            customer.PrintOrders();
            Console.ReadLine();
        }
    }
}