using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy_Hokemon[] ChallengersArray = new Enemy_Hokemon[3];
            Battle_Arena newBattleObject = new Battle_Arena();

            Random rnd = new Random();

            Boolean repeatGame = true;
            string result;

            Console.WriteLine("Hello welcome to Hokeworld home of the Hokemon\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("");

            // Instantiation of new Hokemon

            Halor playerhoke = new Halor(); // Instantiate new Hokemon object to as Hoke01 

            playerhoke.get_details();
            Console.WriteLine("Attack Value is: {0}", playerhoke.attackCalculator());
            Console.WriteLine("Defence Value is: {0}\n", playerhoke.defenceCalculator());
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("");

            Enemy_Hokemon hoke02 = new Enemy_Hokemon();
            Console.WriteLine("An enemey Hokemon appeared!\n");
            hoke02.get_details();
            Console.WriteLine("Attack Value is: {0}", hoke02.attackCalculator());
            Console.WriteLine("Defence Value is: {0}\n", hoke02.defenceCalculator());
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("");

            while (repeatGame == true)
            {
                newBattleObject.requestAChallenger(hoke02);

                for (int i = 0; i<3; i++)
                {
                    ChallengersArray[i] = new Enemy_Hokemon();
                }

                newBattleObject.theBattle(ChallengersArray[rnd.Next(0, ChallengersArray.Length)], playerhoke);

            }



            /* Hinstinct hoke03 = new Hinstinct(); // instantiate from paret class

             Halor hoke04 = new Halor(); // instantiate from halor child class


             //Demonstrating example of polymorphism
             //With hoke03 an instance of Hokemon class
             //With hoke04 an instance of halor inherited from Hokemon class
             hoke03.definition();
             hoke04.definition();
            */

            newBattleObject.requestAChallenger(hoke02);

        }   
    }
}
