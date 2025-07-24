using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InterfaceTraining[] t = new InterfaceTraining[]
                { new Durga(),
                new Lakshmi()
                };
            foreach (InterfaceTraining training in t)
            {
                training.Name();
                training.Email();
                Console.WriteLine("---------------------------------");
            }

        }
    }
}
