﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExamples
{
    internal class Employ
    {
        public int Empno {  get; set; }
        public string Name { get; set; }
        public double Basic { get; set; }

        public override string ToString()
        {
            return "Employ No " + Empno + " Employ Name " + Name + " Employ Basic " +Basic;
        }
    }
}
