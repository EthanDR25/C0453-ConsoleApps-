using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App06
{
    public class Game
    {
        public const int MAXIMUM_ROUND = 8;

        public int Round { get; set; }

        public int LastRound { get; set; }

        public Player Human { get; }

        public Player Computer { get; }

        public Player CurrentPlayer { get; set; }

        public Player Winner { get; set; }

        public int score;

        private Random generator = new Random(55);

        public Game(string name)
        {
            Human = new Player(name, GamePlayers.Player);
            Computer = new Player("Computer", GamePlayers.Computer);

            Round = 0;
        }


        public void Start()
        {

            Round = 1;
            LastRound = 8;

            CurrentPlayer = Human;
        }

        public void MakeComputerChoice()
        {

            int choice = generator.Next(1, 4);

            switch (choice)
            {
                case 1: Computer.Choice = GameChoices.Paper; break;
                case 2: Computer.Choice = GameChoices.Rock; break;
                case 3: Computer.Choice = GameChoices.Scissors; break;
            }
        }

        public void Run()
        {
            string choice = Console.ReadLine();

            MakeComputerChoice();

            if (choice == "Paper")
            {
                Console.Clear();
                ConsoleHelper.OutputHeading("        RPS Game");
                Console.WriteLine($"Your choice: {choice}");
                Console.WriteLine();
                Console.WriteLine($"Computer's choice: {Computer.Choice}");
                Console.WriteLine();
                Console.WriteLine($"Your Score: {Human.Score}");
                Console.WriteLine();
                Console.WriteLine($"Computer's Score: {Computer.Score}");
                GameImages.DrawPaper(28, 10);
            }
            else if (choice == "Rock")
            {
                Console.Clear();
                ConsoleHelper.OutputHeading("        RPS Game");
                Console.WriteLine($"Your choice: {choice}");
                Console.WriteLine();
                Console.WriteLine($"Computer's choice: {Computer.Choice}");
                Console.WriteLine();
                Console.WriteLine($"Your Score: {Human.Score}");
                Console.WriteLine();
                Console.WriteLine($"Computer's Score: {Computer.Score}");
                GameImages.DrawRock(28, 10);
            }
            else if (choice == "Scissors")
            {
                Console.Clear();
                ConsoleHelper.OutputHeading("        RPS Game");
                Console.WriteLine($"Your choice: {choice}");
                Console.WriteLine();
                Console.WriteLine($"Computer's choice: {Computer.Choice}");
                Console.WriteLine();
                Console.WriteLine($"Your Score: {Human.Score}");
                Console.WriteLine();
                Console.WriteLine($"Computer's Score: {Computer.Score}");
                GameImages.DrawScissors(28, 10);
            }

            if (Computer.Choice == GameChoices.Paper)
            {

                GameImages.DrawPaper(71, 10);
            }
            else if (Computer.Choice == GameChoices.Rock)
            {
                GameImages.DrawRock(71, 10);
            }
            else if (Computer.Choice == GameChoices.Scissors)
            {

                GameImages.DrawScissors(71, 10);
            }

            if (choice == "Rock" && Computer.Choice == GameChoices.Paper)
            {
                Computer.Score += 2;
            }
            else if (choice == "Paper" && Computer.Choice == GameChoices.Rock)
            {
                Human.Score += 2;
            }
            else if (choice == "Scissors" && Computer.Choice == GameChoices.Paper)
            {
                Computer.Score += 2;
            }
            else if (choice == "Rock" && Computer.Choice == GameChoices.Scissors)
            {
                Human.Score += 2;
            }
            else if (choice == "Scissors" && Computer.Choice == GameChoices.Rock)
            {
                Computer.Score += 2;
            }
            else if (choice == "Paper" && Computer.Choice == GameChoices.Scissors)
            {
                Computer.Score += 2;
            }

        }



        public void End()
        {
            if (Computer.Score > Human.Score)
            {
                Winner = Computer;
                Console.WriteLine("The Computer has won");
            }
            else if (Computer.Score < Human.Score)
            {
                Winner = Human;
                Console.WriteLine($"You win");
            }
            else Winner = null;
        }
    }  
    
}
