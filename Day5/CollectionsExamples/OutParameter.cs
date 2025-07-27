using System;

namespace CollectionsExamples
{
    internal class OutParameter
    {
        public void Show(int empno, out string name, out double basic)
        {
            name = string.Empty;
            basic = 0;
            if (empno == 1)
            {
                name = "RajaShyamala";
                basic = 98464;
            }
            if (empno == 2)
            {
                name = "Lakshmi";
                basic = 86586;
            }
            if (empno == 3)
            {
                name = "Devaki";
                basic = 86738;
            }
        }
        static void Main(string[] args) 
        {
            int empno;
            Console.WriteLine("Enter Employ number ");
            empno = Convert.ToInt32(Console.ReadLine());
            OutParameter outParameter = new OutParameter();
            string name;
            double basic;
            outParameter.Show(empno, out name,out basic);
            Console.WriteLine("Name is " +name);
            Console.WriteLine("Basic is " +basic);


        }
    }
}
