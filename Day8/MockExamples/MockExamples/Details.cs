﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExamples
{
    internal class Details : IDetails
    {
        public string ShowCompany()
        {
            return "It's from Wipro Bangalore...";
        }

        public string ShowStudent()
        {
            return "Hi I am Srinika...";
        }
    }
}
