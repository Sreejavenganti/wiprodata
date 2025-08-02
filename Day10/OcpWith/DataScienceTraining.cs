using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpWith
{
    internal class DataScienceTraining : ITraining
    {
        public void Info()
        {
            Console.WriteLine("DataScience for Weekend...");
        }

        public void Timimg()
        {
            Console.WriteLine("Its from 9 to 6");
        }
    }
}
