using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    internal class ArrayStr
    {
        public void Show()
        {
            string[] names = new string[]
            {
                "Anjani", "Krishna", "Ganesh", "Abhyansh", "Kabir"

            };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        static void Main(string[] args)
        {
            ArrayStr arrayStr = new ArrayStr();
            arrayStr.Show();
        }
    }
}
