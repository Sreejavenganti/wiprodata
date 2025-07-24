using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstarctEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flowers[] flowers = new Flowers[] {
                new Jasmine(),
                new Lotus(),
                new Hibiscus(),
            };
            foreach (Flowers flower in flowers)
            {
                flower.Colour();
                flower.Name();
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
