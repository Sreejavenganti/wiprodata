using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ExtensionLibrary;

namespace ExtensionEx2
{
    internal static class MissingData
    {
        public static string Milestone3(this Operations oper)
        {
            return "Milestone3 is on .Net core JWT web API";
        }
        public static string Milestone4(this Operations oper)
        {
            return "Milestone4 is on React and .Net core Combination ";
        }
        public static string Project(this Operations oper)
        {
            return "Capstone Project to be submitted Compulsory ";
        }
    }
}
