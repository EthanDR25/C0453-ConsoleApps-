using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App06
{
    public class GameView
    {
        private Game game;

        public void Play()
        {

            ConsoleHelper.OutputHeading("        RPS Game");

            SetupConsole();

            bool wantToQuit = false;

            do
            {
              
                StartGame();

                game.Run();

                game.Round++;

            }
            while(!wantToQuit);
        }

        public void StartGame()
        {
            
            if (game == null)
            {
                Console.WriteLine("Please enter your name: ");
                string name = Console.ReadLine();

                game = new Game(name);
            }

            game.Start();
        }

        private void SetupConsole()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        private void DisplayChoice(GameChoices choice)
        {
           
            if(choice == GameChoices.Paper)
            {
                Console.WriteLine("\n\n");
                GameImages.DrawPaper(28, 10);
            }
            else if(choice == GameChoices.Rock)
            {
                Console.WriteLine("\n\n");
                GameImages.DrawRock(28, 10);
            }
            else if(choice == GameChoices.Scissors)
            {
                Console.WriteLine("\n\n");
                GameImages.DrawScissors(28, 10);
            }
        }
    }
}
