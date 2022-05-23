using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    [Serializable]
    class carPink : Vehicle
    {
       
        public carPink() : base()
        {
           
            haveContent = false;
            _brand = "BMW";
            _kmh = 250;
            _release_year = 2020;
            
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
        ~carPink() { }
    }
   

}
