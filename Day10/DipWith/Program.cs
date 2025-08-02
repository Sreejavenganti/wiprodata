using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipWith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITrainerData trainer1 = new DotnetInfo();
            ITrainerData trainer2 = new JavaInfo();

            TrainerUtil trainerUtil1 = new TrainerUtil(trainer1);
            TrainerUtil trainerUtil2 = new TrainerUtil(trainer2);

            trainerUtil1.ShowInfo();
            trainerUtil2.ShowInfo();
        }
    }
}
