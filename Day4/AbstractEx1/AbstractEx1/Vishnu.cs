using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEx1
{
    internal class Vishnu : Training
    {
        public override void Email()
        {
            Console.WriteLine("Email is Vishnu@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("Name is Vishnu ");
        }
    }
}
