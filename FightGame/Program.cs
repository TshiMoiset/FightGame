using System;

namespace FightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int KongFu = 1000;
            int AlCoholic = 1000;
            bool gameover = true;


            Random number = new Random();
            int hit = number.Next(1, 1001);

            Console.WriteLine("ULTIMATE FIGHT");
            Console.WriteLine("Kong Fu VS Al Coholic");

            while ()
            {
                Console.WriteLine("Kong Fu " + hit + "");
                Console.WriteLine("Al Coholic lost " + hit + " hp");
            }
            if (KongFu == 0)
            {
                AlCoholicwin();
            }

            if (AlCoholic == 0)
            {
                Kongfuwins();
            }


            Console.ReadLine();
        }

        static void AlCoholicwin()
        {
            Console.WriteLine("Al Coholic Win");
            Console.ReadLine();
        }
        static void Kongfuwins()
        {

            Console.WriteLine("Kong Fu win");
            Console.ReadLine();
        }

    }
}




