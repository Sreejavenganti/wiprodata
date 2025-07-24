using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOps
{
    internal class OverloadEx1
    {
        public void Show(int x)
        {
            Console.WriteLine("Show method int " +x);
        }
        public void Show(string x)
        {
            Console.WriteLine("Show method string " + x);
        }
        public void Show(double x)
        {
            Console.WriteLine("Show method double " +x);
        }

        static void Main(string[] args)
        {
            OverloadEx1 obj = new OverloadEx1();
            obj.Show(10);
            obj.Show(20.0);
            obj.Show("Wipro");
        }
        
        
    }
}
