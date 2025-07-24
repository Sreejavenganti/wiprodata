using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctEx2
{
    internal class Jasmine : Flowers
    {
        public override void Colour()
        {
            Console.WriteLine("Colour is White   ");
        }

        public override void Name()
        {
            Console.WriteLine("Name is Jasmine  ");
        }
    }
}
