using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Voting
    {
        public void Show(int age)
        {
            if (age < 18)
            {
                throw new VotingException("Not elligible for voting ");
            }
            Console.WriteLine("Elligible for Voting");
        }
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter age ");
            age = Convert.ToInt32(Console.ReadLine());
            Voting voting = new Voting();
            try
            {
                voting.Show(age);
            }
            catch(VotingException v)
            {
                Console.WriteLine(v.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }
    }
}
