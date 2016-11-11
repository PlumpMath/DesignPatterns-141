using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public interface IMath
    {
        int Add(int x, int y);
        int Sub(int x, int y);
    }

    public class Math:IMath
    {
        public int Add(int x, int y)
        {
            return x+y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }
    }

    public class MathProxy : IMath
    {
        private  Math _math = new Math();
        public int Add(int x, int y)
        {
            return _math.Add(x, y);
        }

        public int Sub(int x, int y)
        {
            return _math.Sub(x, y);
        }
    }
}
