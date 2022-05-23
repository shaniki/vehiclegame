using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    [Serializable]
    class carOrange : Vehicle
    {
        public carOrange() : base()
        {
            haveContent = false;
            _brand = "Lamborghini";
            _kmh = 265;
            _release_year = 2019;
            
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
        ~carOrange() { }
    }
}
