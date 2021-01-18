using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon
{
    class Battle_Arena
    {
        public void requestAChallenger(Enemy_Hokemon requestor)
        {
            System.Threading.Thread.Sleep(10000);
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



            bool X;
            X = false;
            while(X == false)
            {
                string chosenAttackMove;
                string[] attackMoves = { "Punches", "Bites", "Scratches", "Pummels", "Hurts", "Digs under" };
                Random rnd = new Random();
                int randomValue;
                randomValue = rnd.Next(0, 6);
                chosenAttackMove = attackMoves[randomValue];

               
                Random attackCalcrnd = new Random();
                int attackCalcRandomValue;
                attackCalcRandomValue = attackCalcrnd.Next(1, 5);

                Random defendCalcrnd = new Random();
                int defendCalcRandomValue;
                defendCalcRandomValue = defendCalcrnd.Next(2, 8);

              


                if (attacker.attackCalculator() > defender.defenceCalculator())
                {
                    Console.WriteLine("{0} {1} {2}", attacker.Name, chosenAttackMove, defender.Name);
                    int damage;
                    damage = (attacker.attackCalculator() - defender.defenceCalculator());
                    defender.Health = defender.Health - damage;
                    Console.WriteLine("The attack dealt {0} damage!. {1} has {2} health left!", damage, defender.Name, defender.Health);
                    if (defender.Health < 1)
                    {
                        Console.WriteLine("Your {0} has died! You lose", defender.Name);
                        X = true;

                    } 
                }
                else
                {
                    Console.WriteLine("{0}'s attack failed", attacker.Name);
                }

                string defenderChosenAttackMove;
                string[] defenderAttackMoves = { "Punches", "Bites", "Scratches", "Pummels", "Hurts", "Digs under" };
                Random defRnd = new Random();
                int defRandomValue;
                defRandomValue = defRnd.Next(0, 6);
                defenderChosenAttackMove = defenderAttackMoves[defRandomValue];

                if (defender.attackCalculator() > attacker.defenceCalculator())
                {
                    Console.WriteLine("{0} {1} {2}", defender.Name, chosenAttackMove, attacker.Name);
                    int damage;
                    damage = (defender.attackCalculator() - attacker.defenceCalculator());
                    attacker.Health = attacker.Health - damage;
                    Console.WriteLine("The attack dealt {0} damage!. {1} has {2} health left!", damage, attacker.Name, attacker.Health);
                    if (attacker.Health < 1)
                    {
                        Console.WriteLine("{0} has died! You win", attacker.Name);
                        X = true;

                    }
                }
                else
                {
                    Console.WriteLine("{0}'s attack failed", defender.Name);
                }

            }
        }
    }
}
