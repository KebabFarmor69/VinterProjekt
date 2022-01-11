
using System;
using System.Collections.Generic;

namespace VinterProjekt
{
    class Program
    {
        static void Main(string[] args)
        {

            Choices choices = new Choices();
            Preparation preparation = new Preparation();

            bool loopIsRunning = true;

            /*
                Ett matlagningsspel där man har en viss summa att
                spendera, och ska välja ingredienser att lägga i en
                gryta. Sedan finns det en jury som gillar olika 
                ingredienser eller smaker.
           */
            while (loopIsRunning)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(@" 
____________________________________________________________________________________________________________________
   _____ _    _ ______ ______    _____ _____ __  __ _    _ _            _______ ____  _____    ___   ___ ___  ___  
  / ____| |  | |  ____|  ____|  / ____|_   _|  \/  | |  | | |        /\|__   __/ __ \|  __ \  |__ \ / _ \__ \|__ \ 
 | |    | |__| | |__  | |__    | (___   | | | \  / | |  | | |       /  \  | | | |  | | |__) |    ) | | | | ) |  ) |
 | |    |  __  |  __| |  __|    \___ \  | | | |\/| | |  | | |      / /\ \ | | | |  | |  _  /    / /| | | |/ /  / / 
 | |____| |  | | |____| |       ____) |_| |_| |  | | |__| | |____ / ____ \| | | |__| | | \ \   / /_| |_| / /_ / /_ 
  \_____|_|  |_|______|_|      |_____/|_____|_|  |_|\____/|______/_/    \_\_|  \____/|_|  \_\ |____|\___/____|____|
____________________________________________________________________________________________________________________
                                                                                                                   ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you have the abilities to become a master chef?\n\nTest your skills in this 100% accurate Chef Simulator (2022) to find out if you are fit to become a real chef.");
                Console.Write("You have to pick, choose and mix ingredients to make a delicious dish, which a ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("JURY");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" will judge. Try to get the highest score!");
                Console.Write("\nPlease press ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ENTER");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" to continue.");

                Console.ReadLine();
                Console.Clear();

                int money = 200;

                Console.Write("\nNow is your time to shine. Your total amount of money is ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(money);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("$.");
                Console.Write("\n\nNow, please press ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ENTER");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" to begin your journey.");

                Console.ReadLine();
                Console.Clear();


                preparation.PreparationProcess(
                    choices.ChoicesOfIngredients(money)
                );



                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\nPress ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("ENTER ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("to play again.");
                Console.Write("\n\nPress ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ESCAPE ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("to exit.");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    loopIsRunning = false;
                }

                else
                {
                    Console.ReadLine();
                }













            }
        }
    }
}


