﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspWithout
{
    internal class Second : First
    {
        public new void Show()
        {
            Console.WriteLine("Show method from Second Class..");
        }
    }
}
