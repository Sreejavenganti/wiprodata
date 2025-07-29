using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockDemo
{
    public class WiproData : IWiproData
    {
        public string MilestoneExam1()
        {
            return "Milestone Exam 1 is on July 30";
        }

        public string MilestoneExam2()
        {
            return "Milestone Exam 2 is on Aug 8";
        }
    }
}
