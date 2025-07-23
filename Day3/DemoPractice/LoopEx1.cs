using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    internal class LoopEx1
    {
        public void Show()
        {
            int i = 0;
            int count = 10;
            while (i < count)
            {
                Console.WriteLine("Welcome to Paradise ");
                count++;
            }
        }
        static void Main()
        {
            LoopEx1 loopEx1 = new LoopEx1();
            loopEx1.Show();
        }
    }
}
