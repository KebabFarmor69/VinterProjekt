
using System;

namespace VinterProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Ett matlagningsspel där man har en viss summa att
                spendera, och ska välja ingredienser att lägga i en
                gryta. Sedan finns det en jury som gillar olika 
                ingredienser eller smaker.
           */

            Console.WriteLine(@" 
   _____ _    _ ______ ______    _____ _____ __  __ _    _ _            _______ ____  _____    ___   ___ ___  ___  
  / ____| |  | |  ____|  ____|  / ____|_   _|  \/  | |  | | |        /\|__   __/ __ \|  __ \  |__ \ / _ \__ \|__ \ 
 | |    | |__| | |__  | |__    | (___   | | | \  / | |  | | |       /  \  | | | |  | | |__) |    ) | | | | ) |  ) |
 | |    |  __  |  __| |  __|    \___ \  | | | |\/| | |  | | |      / /\ \ | | | |  | |  _  /    / /| | | |/ /  / / 
 | |____| |  | | |____| |       ____) |_| |_| |  | | |__| | |____ / ____ \| | | |__| | | \ \   / /_| |_| / /_ / /_ 
  \_____|_|  |_|______|_|      |_____/|_____|_|  |_|\____/|______/_/    \_\_|  \____/|_|  \_\ |____|\___/____|____|
                                                                                                                   ");
            Console.WriteLine("Do you have the abilities to become a master chef?\n Test your skills in this 100% accurate Chef Simulator (2022) to find out if you are fit to become a real chef.");
            Console.WriteLine("You have to pick, choose and mix ingredients to make a delicious dish, which a jury will judge. Try to get the highest score!");



            Protein beef = new Protein(921, 75);
            Protein chicken = new Protein(853, 60);
            Protein fish = new Protein(687, 65);
            Protein beans = new Protein(469, 20);

            Vegetables tomato = new Vegetables(738, 30);
            Vegetables cucumber = new Vegetables(439, 40);
            Vegetables onion = new Vegetables(964, 15);
            Vegetables salad = new Vegetables(276, 30);

            Liquid cream = new Liquid(853, 25);
            Liquid milk = new Liquid(680, 20);
            Liquid water = new Liquid(142, 5);
            Liquid broth = new Liquid(593, 30);

            Spices oregano = new Spices(659, 30);
            Spices basil = new Spices(720, 35);
            Spices parsley = new Spices(626, 30);
            Spices thyme = new Spices(525, 25);

        }
    }
}


