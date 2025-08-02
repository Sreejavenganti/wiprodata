using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipWithout
{
    internal class DotnetTrainingInfo
    {
        private DotnetTraining dotnetTraining;

        public DotnetTrainingInfo( DotnetTraining dotnetTraining )
        {
            this.dotnetTraining = dotnetTraining;
        }
        public void Details()
        {
            dotnetTraining.TrainerName();
            dotnetTraining.City();
        }

       
    }
}
