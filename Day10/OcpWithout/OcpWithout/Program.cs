using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpWithout
{
    internal class Program
    {
        public static void ShowInfo(string str)
        {
            if (str == "Dotnet")
            {
                DotnetTraining training = new DotnetTraining();
                training.Show();
                training.Timing();
            }
            if (str == "Java")
            {
                DotnetTraining training = new DotnetTraining();
                training.Show();
                training.Timing();
            }
            if (str == "Sap")
            {
                DotnetTraining training = new DotnetTraining();
                training.Show();
                training.Timing();
            }
        }
        static void Main(string[] args) 
        {
            string tinfo;
            Console.WriteLine("Enter Training (Dotnet/Java/Sap)..");
            tinfo = Console.ReadLine();
            ShowInfo(tinfo);

        }
    }
}
