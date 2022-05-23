using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.ComponentModel;


namespace WindowsFormsApp3
{
    [Serializable]
    class Ambulance : BigCars
    {
        int savelife;
        public Ambulance() : base()
        {
            haveContent = false;
            _brand = "Chevrolet";
            _kmh = 150;
            _release_year = 1999;
            weight = 3500;
        }
        Random rand1 = new Random();
        Random rand2 = new Random();
        public bool savelives()
        {
            savelife = rand1.Next(1, 2);
            switch (savelife)
            {
                case 1:
                   Emergency = true;
                    break;
                case 2:
                    Emergency = false;
                    break;
            }
            return Emergency;
        }
        public override int _Id()
        {
            int id = rand2.Next(100, 999);
            return id;
        }
        public override string Content()
        {
            return "Medical equipment";

        }

        public override void makeNoise()
        {

            System.Media.SoundPlayer siren = new System.Media.SoundPlayer(Properties.Resources.TF003);
            siren.Play();
        }

        ~Ambulance() { }



    }
}
