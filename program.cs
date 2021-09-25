using System;

namespace Dicegame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;
            
            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                //first we print out a message 
                Console.WriteLine("Press any key to roll dice...");
                //read key
                Console.ReadLine();
                //print a random number 1 - 7
                playerRandomNum = random.Next(1, 7);
                //print out message & random number
                Console.WriteLine("You rolled a " + playerRandomNum);
                
                Console.WriteLine("...");
                //it makes a thread wait 1000 miliseconds(1 second) before generating/displaying 
                System.Threading.Thread.Sleep(1000);
                //generates a random number 1 -7 for computer player
                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy rolled a " + enemyRandomNum);
                //if else statment to determine points for each player adding ++ to player that wins 
                if(playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round!");

                }
                else if(playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round!");
                } else
                {
                    Console.WriteLine("Tie!");
                }
                //prints out to the console the current points for each player 
                Console.WriteLine("The score is now - Player : " + playerPoints + "| Enemy : " + enemyPoints + "|");
                Console.WriteLine();
            }
            //if else statment that determines the over all game winner. 
            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("You win!");
            }
            else if (playerPoints < enemyPoints)
            {
                Console.WriteLine("You lose!");

            }
            else
            {
                Console.WriteLine("Its a draw!");
            }
            Console.ReadKey();


        }
    }
}
