using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    [Serializable]
    class BigCars : Vehicle
    {
       
        protected bool Emergency;
        protected double weight;
 
        public BigCars() : base()
        {
            haveContent = false;
            Emergency = false;
            weight = 0;
            speed = 6;
        }

        ~BigCars() { }
   


    }
}
