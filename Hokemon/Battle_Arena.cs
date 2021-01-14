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
                randomValue = rnd.Next(0, 5);
                chosenAttackMove = attackMoves[randomValue];


                if (attacker.attackCalculator > defender.defenceCalculator)
                {

                }
            }
        }
    }
}
