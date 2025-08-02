using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipWith
{
    internal class TrainerUtil
    {
        private ITrainerData trainerData;

        public TrainerUtil(ITrainerData trainerData)
        {
            this.trainerData = trainerData;
        }
        public void ShowInfo()
        {
            trainerData.Name();
            trainerData.City();
            trainerData.Country();
        }
    }
}
