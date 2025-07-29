using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExamples
{
    internal class PredicateNew5
    {
        public static bool Attendance(string status)
        {
            if (status.ToUpper().Equals("YES"))
                {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Attendance status (YES/NO)");
            string status = Console.ReadLine();
            Predicate<String> obj = Attendance;
            Console.WriteLine(obj(status));
        }
    }
}
