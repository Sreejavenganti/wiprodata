using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    internal class Quiz2
    {
        public void Incre( ref int x)
        {
            ++x;
        }
        static void Main()
        {
            int x = 12;
            Quiz2 quiz = new Quiz2();
            quiz.Incre(ref x);
            Console.WriteLine(x);
        }
    }
}
