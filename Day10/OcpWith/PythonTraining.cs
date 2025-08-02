using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpWith
{
    internal class PythonTraining : ITraining
    {
        public void Info()
        {
            Console.WriteLine("Python Training is being Conducted...");
        }

        public void Timimg()
        {
            Console.WriteLine("Timimg is From 9 to 6 ");
        }
    }
}
