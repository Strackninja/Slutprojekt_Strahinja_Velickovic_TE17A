using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojekt
{
    public class taekwondo : fighter
    {
        public taekwondo()
        {
            name = "Taekwondo";
            hp = 100;
            weapon = "legs";
            
        }

        /*public int Randomnumber(int min , int max) // försök att få denna o fungera innan nästa lektion
        {
            Random random = new Random()
            return random.Next(3, 20);
        }*/
    }
}
