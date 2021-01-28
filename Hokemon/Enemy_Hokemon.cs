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

        public void get_details()
        {
            Console.WriteLine("***************\nName: {0} \nHealth: {1}/{2} \nAttack: {3} \nSpeed: {4} \nDefence {5} \n***************\n", name, health, max_health, attack, speed, defence);
        }

        public void provide_name()
        {
            string[] names = { "Hulbasour", "Heevee", "Hitto", "Horlax", "Harmander", "Hirtle" };

            Random rnd = new Random();
            int randomValue;
            randomValue = rnd.Next(0, 5);
            name = names[randomValue];

        }

        public int random_int_generator(int min_value, int max_value) // PARAMETERS (int min_value, int max_value)
        {
            Random rnd = new Random();

            int randomValue;

            randomValue = rnd.Next(min_value, max_value);

            return randomValue;
        }

        public int attackCalculator()
        {
            int attackValue;
            Random rnd = new Random();

            attackValue = (attack + speed) / 10 * rnd.Next(1,5);

            return attackValue;
        }

    }
}
