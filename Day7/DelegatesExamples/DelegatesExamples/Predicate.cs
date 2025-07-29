using System;

namespace DelegatesExamples
{
    internal class Predicate
    {
        public static bool Check(string gender)
        {
            if (gender.Equals("MALE") || gender.Equals("FEMALE"))
            {
                return true;
            }
            return false;
        }
        public static bool MartialStatus(int status)
        {
            if (status == 1 || status == 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter gender MALE/FEMALE ");
            string gender = Console.ReadLine();
            Console.WriteLine("Enter Martialstatus (1 or 0) ");
            int mstat = Convert.ToInt32(Console.ReadLine());
            Predicate<String> obj = Check;
            Console.WriteLine(obj(gender));
            Predicate<int> obj1 = MartialStatus;
            Console.WriteLine(obj1(mstat));
        }
    }

}
