using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OcpWith
{
    internal class Program
    {
        public static void Show(ITraining training)
        {
            training.Info();
            training.Timimg();
        }

        static void Main(string[] args)
        {
            DotnetTraining training = new DotnetTraining();
            Show(training);
            JavaTraining javaTraining = new JavaTraining();
            Show(javaTraining);
            PythonTraining pythonTraining = new PythonTraining();
            Show(pythonTraining);
            DataScienceTraining data = new DataScienceTraining();
            Show(data);
        }
    }
}
