using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Battle_Arena
    {
        public void requestAChallenger(Enemy_Hokemon requestor)
        {
            Console.WriteLine("{0}: 'I want a challenge'", requestor.Name);
            System.Threading.Thread.Sleep(2000);
        }

        public void theBattle(Enemy_Hokemon attacker, Hokemon defender)
        {
            Console.WriteLine("{0}: waits...", attacker.Name);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("{0}: and waits...", attacker.Name);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("{0}: 'I accept the challenge!'", defender.Name);
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("{0} and {1} prepare to fight!", attacker.Name, defender.Name);

            int round = 1;
            bool X;
            X = false;
            while (X == false)
            {
                string chosenAttackMove;
                string[] attackMoves = { "Punches", "Bites", "Scratches", "Pummels", "Hurts", "Digs under" };
                Random rnd = new Random();
                int randomValue;
                randomValue = rnd.Next(0, 6);
                chosenAttackMove = attackMoves[randomValue];

                if (X == false)
                {
                    Console.WriteLine("\nRound: {0}", round);
                    round++;
                    Console.WriteLine("****************\n");
                    Console.WriteLine("{0} {1} {2}", attacker.Name, chosenAttackMove, defender.Name);
                    int damage;
                    Random attackCalcrnd = new Random();
                    int attackCalcRandomValue;
                    attackCalcRandomValue = attackCalcrnd.Next(3, 5);

                    Random defendCalcrnd = new Random();
                    int defendCalcRandomValue;
                    defendCalcRandomValue = defendCalcrnd.Next(1, 2);

                    damage = ((attacker.attackCalculator() + attackCalcRandomValue) - (defender.defenceCalculator() + defendCalcRandomValue));
                    if (damage < 0)
                    {
                        damage = 0;
                    }
                    defender.Health = defender.Health - damage;
                    if (defender.Health < 0)
                    {
                        defender.Health = 0;
                    }
                    Console.WriteLine("The attack dealt {0} damage!. {1} has {2} health left!", damage, defender.Name, defender.Health);
                    Console.WriteLine("\n****************\n");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    if (defender.Health < 1)
                    {
                        Console.WriteLine("Your Hokemon, {0} has died! You lose!", defender.Name);
                        X = true;

                    }


                   
                    string defenderChosenAttackMove;
                    string[] defenderAttackMoves = { "Punches", "Bites", "Scratches", "Pummels", "Hurts", "Digs under" };
                    Random defRnd = new Random();
                    int defRandomValue;
                    defRandomValue = defRnd.Next(0, 6);
                    defenderChosenAttackMove = defenderAttackMoves[defRandomValue];
                  
                    if (X == false)
                    {
                        Console.WriteLine("\n****************\n");
                        Console.WriteLine("{0} {1} {2}", defender.Name, defenderChosenAttackMove, attacker.Name);
                        int damage2;
                        Random attackCalcrnd2 = new Random();
                        int attackCalcRandomValue2;
                        attackCalcRandomValue2 = attackCalcrnd.Next(3, 5);

                        Random defendCalcrnd2 = new Random();
                        int defendCalcRandomValue2;
                        defendCalcRandomValue2 = defendCalcrnd.Next(1, 2);

                        damage2 = ((defender.attackCalculator() + attackCalcRandomValue2) - attacker.defenceCalculator() + (defendCalcRandomValue2));
                        if (damage2 <= 0)
                        {
                            damage2 = 0;
                        }
                        attacker.Health = attacker.Health - damage2;
                        if (attacker.Health < 0)
                        {
                            attacker.Health = 0;
                        }
                        Console.WriteLine("The attack dealt {0} damage!. {1} has {2} health left!", damage2, attacker.Name, attacker.Health);
                        Console.WriteLine("\n****************\n");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        if (attacker.Health < 1)
                        {
                            Console.WriteLine("{0} has died! You win!", attacker.Name);
                            X = true;

                        }
                    }
                }
            }
        }
    }
}
