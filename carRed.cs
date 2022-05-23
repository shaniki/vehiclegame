using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    [Serializable]
    class carRed :Vehicle

    {
        public carRed() : base()
        {
            haveContent = false;
            _brand = "Mazda";
            _kmh = 195;
            _release_year = 2015;
          
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
       
        ~carRed() { }
    }
}
