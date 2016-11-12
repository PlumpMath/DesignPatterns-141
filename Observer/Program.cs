using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IBM ibm = new IBM();
            Apple apple = new Apple();
            Mobile mobile = new Mobile();
            DisplayBoard displayBoard = new DisplayBoard();
            ibm.RegisterObserver(mobile);
            apple.RegisterObserver(displayBoard);

            ibm.SetPrice(11);

            apple.SetPrice(12);
            Console.ReadLine();

        }
    }
}
