using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class GenericEx2
    {
        static void Main(string[] args)
        {
            List<Int32> namelist = new List<Int32>();
            namelist.Add(1);
            namelist.Add(2);
            namelist.Add(3);
            namelist.Add(4);
            namelist.Add(5);
            namelist.Add(6);

            foreach (int i in namelist)
            {
                Console.WriteLine(i);
            }
        }
    }
}
