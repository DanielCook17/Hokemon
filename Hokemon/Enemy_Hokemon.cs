using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Enemy_Hokemon : Hokemon
    {
     
        public Enemy_Hokemon()    // CONSTRUCTOR METHOD FOR THE ENEMY_HOKEMON
        {
            IsGood = false;
        }

        public void provide_name()
        {
            string[] names = { "Hulbasour", "Heevee", "Hitto", "Horlax", "Harmander", "Hirtle" };

            Random rnd = new Random();
            int randomValue;
            randomValue = rnd.Next(0, 5);
            Name = names[randomValue];

        }

    }
}
