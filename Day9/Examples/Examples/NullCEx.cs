﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    internal class NullCEx
    {
        static void Main()
        {
            string s1 = null;
            string s2 = "Welcome";
            string s3 = "Wipro";

            string s4 = s1 ?? s2;
            Console.WriteLine(s4);
            s4 = s3 ?? s2;
            Console.WriteLine(s4);
           
        }
    }
}
