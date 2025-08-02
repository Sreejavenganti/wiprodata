using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpWith
{
    internal class DotnetTraining : ITraining
    {
        public void Info()
        {
            Console.WriteLine("Dotnet FSD Training Info...");
        }

        public void Timimg()
        {
            Console.WriteLine("Its from 9 am to 6 pm");
        }
    }
}
