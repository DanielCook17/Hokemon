using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Enemy_Hokemon : Hokemon
    {
        // Hokemon attributes


        // CONSTRUCTOR METHOD FOR THE HOKEMON
        public Enemy_Hokemon()
        {
            provide_name();
            IsGood = false;
        }

        public new void provide_name()
        {
            string[] names = { "Hulbasour", "Heevee", "Hitto", "Horlax", "Harmander", "Hirtle" };

            Random rnd = new Random();
            int randomValue;
            randomValue = rnd.Next(0, 5);
            Name = names[randomValue];

        }




    }
}
