using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class player : Vehicle
    {
       public player() : base()
        {
            haveContent = false;
            _brand = "Tesla";
            _kmh = 350;
            _release_year = 2018;
            speed = 12;
        }

        public override void makeNoise()
        {
            System.Media.SoundPlayer honk = new System.Media.SoundPlayer(Properties.Resources.VEHHorn_Recent_car_horn_3__ID_0259__BSB);
            honk.Play();
        }

        ~player() { }
    }
}
