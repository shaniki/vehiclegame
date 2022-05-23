using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    [Serializable]
    class carYellow : Vehicle
    {
        public carYellow() :base()
        {
          haveContent = false;
         _brand= "Hyundai";
         _kmh=185;
         _release_year = 2010;
          
        }
        Random rand = new Random();

        public override int _Id()
        {
            int id = rand.Next(100, 999);
            return id;
        }

        public override string Content()
        {
            return "null";
        }

        ~carYellow() { }

    }
}

