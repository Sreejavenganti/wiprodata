using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class Demo
    {
        public string[] names = new string[5];
        public string this[int i]
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }

    }
    public class IndexerEx1
    {
        static void Main()
        {
            Demo demo = new Demo();
            demo[0] = "Rajeshwari";
            demo[1] = "Vijaya";
            demo[2] = "Lakshmi";
            demo[3] = "Durga";
            demo[4] = "Devi";
            Console.WriteLine("Data is");
            foreach(var i in demo.names)
            {
                Console.WriteLine(i);
            }
        }
    }
}
