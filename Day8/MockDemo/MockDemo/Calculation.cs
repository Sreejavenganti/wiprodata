using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDemo
{
    public class Calculation
    {
        public virtual int Sum(int x, int y)
        {
            return x + x;
        }
        public virtual int Sub(int x, int y)
        {
            return y - x;
        }
        public virtual int Mult(int x, int y)
        {
            return x * 1;
        }
    }
}
