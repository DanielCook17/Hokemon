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

            Boolean repeatGame = false;
            String result;
            int roundCounter;
            roundCounter = 0;

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

            Hinstinct hoke02 = new Hinstinct();
            Console.WriteLine("An enemey Hokemon appeared!\n");
            hoke02.get_details();
            Console.WriteLine("Attack Value is: {0}", hoke02.attackCalculator());
            Console.WriteLine("Defence Value is: {0}\n", hoke02.defenceCalculator());
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("");

            newBattleObject.theBattle(hoke02, playerhoke);

            if (playerhoke.Health > 0)
            {
                Console.WriteLine("\nWould you like to play again? (y/n)");
                result = Console.ReadLine();

                if (result == "y")
                {
                    roundCounter++;
                    repeatGame = true;
                }
                if (result == "n")
                {
                    repeatGame = false;
                    Console.WriteLine("\nYour {0} survived {1} rounds! GAME OVER", playerhoke.Name, roundCounter);
                }
            }
            while (repeatGame == true)
            {

                for (int i = 0; i<3; i++)
                {
                    ChallengersArray[i] = new Enemy_Hokemon();
                }

                
                newBattleObject.theBattle(ChallengersArray[rnd.Next(0, ChallengersArray.Length)], playerhoke);

                if (playerhoke.Health > 0)
                {
                    Console.WriteLine("\nWould you like to play again? (y/n)");
                    result = Console.ReadLine();

                    if (result == "y")
                    {
                        roundCounter++;
                        repeatGame = true;
                    }
                    if (result == "n")
                    {
                        repeatGame = false;
                        Console.WriteLine("\nYour {0} survived {1} rounds! GAME OVER", playerhoke.Name, roundCounter);
                    }
                }
                else
                {
                    repeatGame = false;
                    Console.WriteLine("\nYour {0} survived {1} rounds! GAME OVER", playerhoke.Name, roundCounter);
                }

            }



            /* Hinstinct hoke03 = new Hinstinct(); // instantiate from paret class

             Halor hoke04 = new Halor(); // instantiate from halor child class


             //Demonstrating example of polymorphism
             //With hoke03 an instance of Hokemon class
             //With hoke04 an instance of halor inherited from Hokemon class
             hoke03.definition();
             hoke04.definition();
            */

        }   
    }
}

