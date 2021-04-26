using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 -> Scissors
            // 2 -> Rock 
            // 3 -> Paper 
            Random rnd = new Random();
            int playerB = rnd.Next(1, 4), count = 0, countA = 0, countB = 0, countT = 0;

            while (count != 100)
            {
                if(playerB == 1)
                {
                    countT++;
                }
                else if (playerB == 2)
                {
                    countB++;
                }
                else if(playerB == 3)
                {
                    countA++;
                }
                playerB = rnd.Next(1, 4);
                count++;
            }           

            Console.WriteLine($"Player A wins {countA} of 100 games");
            Console.WriteLine($"Player B wins {countB} of 100 games");
            Console.WriteLine($"Tie: {countT} of 100 games");
        }
    }
}
