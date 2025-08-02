using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipWithout
{
    internal class JavaTrainingInfo
    {
        private JavaTraining javaTraining;

        public JavaTrainingInfo(JavaTraining javaTraining)
        {
            this.javaTraining = javaTraining;
        }
        public void Details()
        {
            javaTraining.TrainerName();
            javaTraining.City();

        }
    }
}
