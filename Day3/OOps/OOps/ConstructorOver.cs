using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps
{
    internal class ConstructorOver
    {
        int a, b;
        public ConstructorOver()
        {
            a = 10; b = 40;
        }
        public ConstructorOver(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Show()
        {
            Console.WriteLine("Value a " +a+  " value b " +b);
        }
        static void Main(string[] args)
        {
            ConstructorOver obj = new ConstructorOver();
            obj.Show();
            ConstructorOver obj2 = new ConstructorOver(35, 45);
            obj2.Show();
        }
    }
}
