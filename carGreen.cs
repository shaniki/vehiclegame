using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    [Serializable]
    internal class carGreen : Vehicle
    {
    
        public carGreen() : base()
        {
            haveContent = false;
            _brand = "Ford";
            _kmh = 195;
            _release_year = 2013;
           
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

        ~carGreen() { }
    }
}
