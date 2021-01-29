using System;

namespace Rock_Paper_Scissors
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            string inputPlayer;
            string inputCPU;
            int randomInt;

            Console.WriteLine("Rock, Paper, Scissors!!");
            Console.Write("Please input a weapon: ");

            //Player's input config
            inputPlayer = Console.ReadLine().ToUpper();

            if (inputPlayer != "SCISSORS" && inputPlayer != "ROCK" && inputPlayer != "PAPER")
            {
                Console.WriteLine("You chose an invalid weapon");
            } else
            {
                Console.WriteLine("You chose " + inputPlayer);
            }
            //CPU's input config
            Random randomNum = new Random();
            randomInt = randomNum.Next(1,4);

            Console.WriteLine("-------------------------------");

            if (randomInt == 1)
            {
                inputCPU = "ROCK";
                Console.WriteLine("Computer chose ROCK");
                if (inputPlayer == "SCISSORS")
                {
                    Console.WriteLine("You Lose");
                } else if (inputPlayer == "ROCK")
                {
                    Console.WriteLine("It's a tie");
                } else 
                {
                    Console.WriteLine("You Win!!");
                }
            } else if (randomInt == 2)
            {
                inputCPU = "PAPER";
                Console.WriteLine("Computer chose paper");
                if (inputPlayer == "SCISSORS")
                {
                    Console.WriteLine("You Win!!");
                } else if (inputPlayer == "ROCK")
                {
                    Console.WriteLine("You Lose");
                } else 
                {
                    Console.WriteLine("It's a tie");
                }
            } else
            {
                inputCPU = "SCISSORS";
                Console.WriteLine("Computer chose SCISSORS");
                if (inputPlayer == "SCISSORS")
                {
                    Console.WriteLine("It's a tie");
                } else if (inputPlayer == "ROCK")
                {
                    Console.WriteLine("You Win!!");
                } else 
                {
                    Console.WriteLine("You Lose");
                }
            }   
            
            Console.ReadLine();
            Console.WriteLine(inputCPU);
        }
    }
}
