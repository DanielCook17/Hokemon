using System;

namespace Hokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to Hokeworld home of the Hokemon");

            // Instantiation of new Hokemon

            Hokemon hoke01 = new Hokemon(); // Instantiate new Hokemon object to as Hoke01 

            hoke01.get_details();
            Console.WriteLine("Attack Value is: {0}", hoke01.attackCalculator());
            Console.WriteLine("Defence Value is: {0}\n", hoke01.defenceCalculator());

            Enemy_Hokemon hoke02 = new Enemy_Hokemon();

            hoke02.get_details();
            Console.WriteLine("Attack Value is: {0}", hoke02.attackCalculator());
            Console.WriteLine("Defence Value is: {0}\n", hoke02.defenceCalculator());

            Hinstinct hoke03 = new Hinstinct(); // instantiate from paret class

            Halor hoke04 = new Halor(); // instantiate from halor child class
            

            //Demonstrating example of polymorphism
            //With hoke03 an instance of Hokemon class
            //With hoke04 an instance of halor inherited from Hokemon class
            hoke03.definition();
            hoke04.definition();

            
            Battle_Arena newBattleObject = new Battle_Arena();

            newBattleObject.requestAChallenger(hoke02);

            newBattleObject.theBattle(hoke02, hoke01);
            
        }   
    }
}
