using System;

namespace diceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoint = 0;
            int enemyPoint = 0;

            Random random = new Random();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();
                playerRandomNum = random.Next(1,7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("....");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1,7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);


                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoint++;
                    Console.WriteLine("Player wins this round");
                } else if (playerRandomNum < enemyRandomNum)
                {
                    enemyPoint++;
                    Console.WriteLine("Enemy win this round");
                }
                else
                {
                    Console.WriteLine("It's a draw");
                }

                Console.WriteLine("The score is now - Player : " +playerPoint + " . Enemy: " +enemyPoint + ".");
                Console.WriteLine();
            }

            if (playerPoint > enemyPoint)
            {
                Console.WriteLine("You WIN!!");
            }else if (enemyPoint > playerPoint)
            {
                Console.WriteLine("You LOSE!!!");
            }
            else
            {
                Console.WriteLine("It's a draw");
            }
            Console.ReadKey();
        }
    }
}
