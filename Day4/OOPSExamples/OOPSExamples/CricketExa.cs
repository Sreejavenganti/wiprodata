using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExamples
{
    internal class CricketExa
    {
        static int score;
        public void Increment(int x)
        {
            score += x;
        }
        
        static void Main(string[] args)
        {
            CricketExa cricket = new CricketExa();
            CricketExa b = new CricketExa();
            CricketExa f = new CricketExa();

            cricket.Increment(10);
            b.Increment(50);
            f.Increment(100);

            Console.WriteLine("Total Score is " +CricketExa.score);

            
        }
    }
}
