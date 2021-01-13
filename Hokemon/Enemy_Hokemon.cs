using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Enemy_Hokemon
    {
        // Hokemon attributes
        private string name;
        private int health;
        private int max_health;
        private int attack;
        private int speed;
        private int defense;

        // CONSTRUCTOR METHOD FOR THE HOKEMON
        public Enemy_Hokemon()
        {
            provide_name();
            max_health = 100;
            health = random_int_generator(10, max_health);
            attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defense = random_int_generator(10, 100);
        }

        public void get_details()
        {
            Console.WriteLine("***************\nName: {0} \nHealth: {1}/{2} \nAttack: {3} \nSpeed: {4} \nDefense {5} \n***************\n", name, health, max_health, attack, speed, defense);
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
    }
}
