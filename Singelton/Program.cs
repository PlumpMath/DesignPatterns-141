using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Threading;

namespace Singelton
{
    class Program
    {
        static void Main(string[] args)
        {

            ThreadStart childref = new ThreadStart(SingeltonInThread);
            
            
            Thread t1 = new Thread(childref);
            Thread t2 = new Thread(childref);
            t1.Start();
            t2.Start();
            //Singelton s1 = Singelton.GetInstance();
            //Singelton s2 = Singelton.GetInstance();
            //s1.Print();
            //s2.Print();
            Console.ReadLine();
        }

        private static void SingeltonInThread()
        {
            Singelton s2 = Singelton.GetInstance();
            s2.Print();
        }
    }
}
