using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            


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





            /* Hinstinct hoke03 = new Hinstinct(); // instantiate from paret class

             Halor hoke04 = new Halor(); // instantiate from halor child class


             //Demonstrating example of polymorphism
             //With hoke03 an instance of Hokemon class
             //With hoke04 an instance of halor inherited from Hokemon class
             hoke03.definition();
             hoke04.definition();
            */

            Battle_Arena newBattleObject = new Battle_Arena();
            newBattleObject.theBattle(hoke02, playerhoke);


        }
    }
}

