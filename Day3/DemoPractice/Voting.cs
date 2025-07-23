using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    internal class Voting
    {
        public void Check(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("Person is eligable for voting");
            }
            else
            {
                Console.WriteLine("Person is not eligable for voting");
            }
        }
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter age ");
            age = Convert.ToInt32(Console.ReadLine());
            Voting voting = new Voting();
            voting.Check(age);
        }

    }
}
