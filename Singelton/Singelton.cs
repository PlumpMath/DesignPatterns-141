using System;

namespace Singelton
{
    public class Singelton
    {
        static Random rnd = new Random();
        private int id;
        private static readonly object _PadLock = new object();
        private static Singelton _singelton;
        public static Singelton GetInstance()
        {
            lock (_PadLock)
            {
                if (_singelton == null)
                    _singelton = new Singelton();

                return _singelton;
           }
           

        }

        private Singelton()
        {
           
            id = rnd.Next(1, 100000);
            System.Threading.Thread.Sleep(2000);
        }

        public void Print()
        {
            Console.WriteLine(id.ToString());
        }
    }
}