using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEx1
{
    internal class Krishna : Training
    {
        public override void Email()
        {
            Console.WriteLine("Email is Krishna@gamil.com"); ;
        }

        public override void Name()
        {
            Console.WriteLine("Name is Krishna");
        }
    }
}
