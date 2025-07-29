using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class DelegateEx2
    {
        public delegate void DelegateEx(string s);

        public static void Show(string s)
        {
            Console.WriteLine("Welcome to Delegates " +s);
        }
        static void Main(string[] args)
        {
            DelegateEx d = new DelegateEx(Show);
            d("Shiva");
        }
    }
}
