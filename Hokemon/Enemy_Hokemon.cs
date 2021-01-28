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
        public int max_health;
        public int attack;
        private int speed;
        public int defence;
        private string team;
        private Boolean isGood;

        // CONSTRUCTOR METHOD FOR THE HOKEMON
        public Boolean IsGood
        {
            get { return isGood; }
            set { isGood = value; }
        }
        public string Team
        {
            get { return team; }
            set { team = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public Enemy_Hokemon()
        {
            provide_name();
            max_health = 100;
            health = random_int_generator(10, max_health);
            attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defence = random_int_generator(10, 100);
        }

        public void definition()
        {
            Console.WriteLine("I am {0}, a member of the Hokemon tribe!", name);
        }
        public string get_name()
        {
            return name;
        }

        public void get_details()
        {
            Console.WriteLine("***************\nName: {0} \nHealth: {1}/{2} \nAttack: {3} \nSpeed: {4} \nDefence {5} \n***************\n", name, health, max_health, attack, speed, defence);
        }

        public void provide_name()
        {
            String[] EnemyNames = {"Heevee","Hitto","Hulbasour","Hikachu"};
            Random rnd = new Random();

            int randomValue;
            randomValue = rnd.Next(0, 3);
            name = EnemyNames[randomValue];
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

            attackValue = (attack + speed) / 10 * rnd.Next(1, 5);

            return attackValue;
        }

        public int defenceCalculator()
        {
            int defenceValue;
            Random rnd = new Random();

            defenceValue = (defence + speed) / 10 * rnd.Next(1, 5);

            return defenceValue;
        }
    }


}

