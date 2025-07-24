using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx2
{
    internal class Demo : IOne, ITwo
    {
        public void Email()
        {
            Console.WriteLine("email is sreeja@gamil.com");
        }

        public void Name()
        {
            Console.WriteLine("Name is Sreeja  ");
        }
    }
}
