using System;

namespace Rock_Paper_scissors
{
    class Program
    {

        static void check_answer(String player , String computer) {
        if (player == "ROCK" && computer == "ROCK")
            Console.WriteLine("→Draw←");

        else if (player == "ROCK" && computer == "PAPER") 
            Console.WriteLine("Computer Win ⭐️");

        else if (player == "ROCK" && computer == "SCISSORS") 
            Console.WriteLine("Player Win ⭐️");

        else if (player == "PAPER" && computer == "PAPER") 
            Console.WriteLine("→Draw←");

        else if (player == "PAPER" && computer == "ROCK") 
            Console.WriteLine("Player Win ⭐️");

        else if (player == "PAPER" && computer == "SCISSORS") 
            Console.WriteLine("Computer Win ⭐️");

        else if (player == "SCISSORS" && computer == "SCISSORS") 
            Console.WriteLine("→Draw←");

        else if (player == "SCISSORS" && computer == "ROCK") 
            Console.WriteLine("Computer Win ⭐️");

        else if (player == "SCISSORS" && computer == "PAPER") 
            Console.WriteLine("Player Win ⭐️");

        else
            Console.WriteLine("Error!");           
    }

        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;

            while (playAgain)
            {
                player = "";
                computer = "";

                Console.Write("Enter ROCK, PAPER, OR SCISSORS");
                player = Console.ReadLine().ToUpper(); 

                switch (random.Next(1 , 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer); 

                switch (player)
                {
                    case "ROCK":
                        check_answer(player , computer);
                        break;
                    case "PAPER":
                        check_answer(player , computer);
                        break;
                    case "SCISSORS":
                        check_answer(player , computer);
                        break;
                    default:
                        Console.WriteLine("Invalid Input!"); 
                        break;
                }

                
            }
        }
    }
}
