using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
    internal class CaseEx1
    {
        public void check(char choice)
        {
            switch (choice)
            {
                case 'a':
                case 'A':
                case '1':
                    Console.WriteLine("Hi I am Vishnu");
                    break;
                case 'b':
                case 'B':
                case '2':
                    Console.WriteLine("Hi I am Shiva");
                    break;
                case 'c':
                case 'C':
                case '3':
                    Console.WriteLine("Hi I am Sreeja");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
            static void Main()
            {
                char choice;
                Console.WriteLine("Enter your choice..");
                choice = Convert.ToChar(Console.ReadLine());
                CaseEx1 obj = new CaseEx1();
                obj.check(choice);
            }
    }
}
