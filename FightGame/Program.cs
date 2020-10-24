using System;

namespace FightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int KongFu = 1000;
            int AlCoholic = 1000;
            //int KongFuHitpoint;
            //int AlCoholicHitPoint;
            bool attack = false;

            Random number = new Random();
            int hit = number.Next(1, 1001);

            Console.WriteLine("ULTIMATE FIGHT");
            Console.WriteLine("Kong Fu VS Al Coholic");

            while (!attack)
            {


                Console.WriteLine("Kong Fu " + hit + " damage");
                Console.WriteLine("Al Coholic lost " + hit + " hp");

                Console.WriteLine("Al Coholic " + hit + " damage");
                Console.WriteLine("Kong lost " + hit + " hp");


                if (KongFu == 0)
                {
                    Console.WriteLine("Al Coholic is the winner");
                }

                if (AlCoholic == 0)
                {
                    Console.WriteLine("Kong Fu winner");
                }

            }

            KongFu -= hit;
            AlCoholic -= hit;


        }



    }
}
