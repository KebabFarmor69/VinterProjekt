using System;
using System.Collections.Generic;

namespace VinterProjekt
{
    public class Choices
    {
        public List<Ingredients> ChoicesOfIngredients(int money)
        {
            List<Ingredients> ingredients = new List<Ingredients>();

            Protein beef = new Protein(921, 75);
            Protein chicken = new Protein(853, 60);
            Protein fish = new Protein(687, 65);
            Protein beans = new Protein(469, 20);

            Console.Write("\nFirst, you will have to buy your ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("PROTEIN");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");

            List<string> proteinList = new List<string>() { "[a] BEEF - " + beef.price + "$", "[b] CHICKEN - " + chicken.price + "$", "[c] FISH - " + fish.price + "$", "[d] BEANS - " + beans.price + "$" };
            Console.Write("\n\n\n");
            proteinList.ForEach(Console.WriteLine);

            bool loop = true;

            while (loop)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A:
                        //BEEF
                        money = money - beef.price;

                        Console.Write("\n\nYou chose BEEF. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(beef);

                        break;

                    case ConsoleKey.B:
                        //CHICKEN
                        money = money - chicken.price;

                        Console.Write("\n\nYou chose CHICKEN. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(chicken);

                        break;

                    case ConsoleKey.C:
                        //FISH
                        money = money - fish.price;

                        Console.Write("\n\nYou chose FISH. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(fish);

                        break;

                    case ConsoleKey.D:
                        //BEANS
                        money = money - beans.price;

                        Console.Write("\n\nYou chose BEANS. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(beans);

                        break;

                    default:

                        Console.Write("\nPlease choose one of the following:\n\n");
                        proteinList.ForEach(Console.WriteLine);

                        break;
                }

            }



            Console.Write("\n\nPlease press ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("ENTER");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" to continue.");

            Console.ReadLine();
            Console.Clear();

            Carbs pasta = new Carbs(873, 25);
            Carbs potato = new Carbs(597, 10);
            Carbs bread = new Carbs(682, 35);
            Carbs noodles = new Carbs(928, 40);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(money);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("$.");

            Console.Write("\n\nSecondly, you will have to buy your ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("CARBS");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(".");

            List<string> carbsList = new List<string>() { "[a] PASTA - " + pasta.price + "$", "[b] POTATO - " + potato.price + "$", "[c] BREAD - " + bread.price + "$", "[d] NOODLES - " + noodles.price + "$" };
            Console.Write("\n\n\n");
            carbsList.ForEach(Console.WriteLine);

            loop = true;

            while (loop)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A:
                        //PASTA
                        money = money - pasta.price;

                        Console.Write("\n\nYou chose PASTA. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(pasta);

                        break;

                    case ConsoleKey.B:
                        //POTATO
                        money = money - potato.price;

                        Console.Write("\n\nYou chose POTATO. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(potato);

                        break;

                    case ConsoleKey.C:
                        //BREAD
                        money = money - bread.price;

                        Console.Write("\n\nYou chose BREAD. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(bread);

                        break;

                    case ConsoleKey.D:
                        //NOODLES
                        money = money - noodles.price;

                        Console.Write("\n\nYou chose NOODLES. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(noodles);

                        break;

                    default:

                        Console.Write("\nPlease choose one of the following:\n\n");
                        carbsList.ForEach(Console.WriteLine);

                        break;
                }
                loop = false;
            }

            Console.Write("\n\nPlease press ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("ENTER");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" to continue.");

            Console.ReadLine();
            Console.Clear();

            Vegetables tomato = new Vegetables(738, 30);
            Vegetables cucumber = new Vegetables(439, 40);
            Vegetables onion = new Vegetables(964, 15);
            Vegetables salad = new Vegetables(276, 30);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(money);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("$.");

            Console.Write("\n\nThirdly, you will have to buy your ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("VEGETABLES");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(ew).");

            List<string> vegetablesList = new List<string>() { "[a] TOMATO - " + tomato.price + "$", "[b] CUCUMBER - " + cucumber.price + "$", "[c] ONION - " + onion.price + "$", "[d] SALAD - " + salad.price + "$" };
            Console.Write("\n\n\n");
            vegetablesList.ForEach(Console.WriteLine);

            loop = true;

            while (loop)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A:
                        //TOMATO
                        money = money - tomato.price;

                        Console.Write("\n\nYou chose TOMATO. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(tomato);

                        break;

                    case ConsoleKey.B:
                        //CUCUMBER
                        money = money - cucumber.price;

                        Console.Write("\n\nYou chose CUCUMBER. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(cucumber);

                        break;

                    case ConsoleKey.C:
                        //ONION
                        money = money - onion.price;

                        Console.Write("\n\nYou chose ONION. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(onion);

                        break;

                    case ConsoleKey.D:
                        //SALAD
                        money = money - salad.price;

                        Console.Write("\n\nYou chose SALAD. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(salad);

                        break;

                    default:

                        Console.Write("\nPlease choose one of the following:\n\n");
                        vegetablesList.ForEach(Console.WriteLine);

                        break;
                }
                loop = false;
            }


            Console.Write("\n\nPlease press ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("ENTER");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" to continue.");

            Console.ReadLine();
            Console.Clear();

            Liquid cream = new Liquid(853, 25);
            Liquid milk = new Liquid(680, 20);
            Liquid water = new Liquid(142, 5);
            Liquid broth = new Liquid(593, 30);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(money);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("$.");

            Console.Write("\n\nFourthly, you will have to buy your ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("LIQUID");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ~moist~.");

            List<string> liquidList = new List<string>() { "[a] CREAM - " + cream.price + "$", "[b] MILK - " + milk.price + "$", "[c] WATER - " + water.price + "$", "[d] BROTH - " + broth.price + "$" };
            Console.Write("\n\n\n");
            liquidList.ForEach(Console.WriteLine);

            loop = true;

            while (loop)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A:
                        //CREAM
                        money = money - cream.price;

                        Console.Write("\n\nYou chose CREAM. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;

                        ingredients.Add(cream);

                        break;

                    case ConsoleKey.B:
                        //MILK
                        money = money - milk.price;

                        Console.Write("\n\nYou chose MILK. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(milk);

                        break;

                    case ConsoleKey.C:
                        //WATER
                        money = money - water.price;

                        Console.Write("\n\nYou chose WATER. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(water);

                        break;

                    case ConsoleKey.D:
                        //BROTH
                        money = money - broth.price;

                        Console.Write("\n\nYou chose BROTH. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(broth);

                        break;

                    default:

                        Console.Write("\nPlease choose one of the following:\n\n");
                        vegetablesList.ForEach(Console.WriteLine);

                        break;
                }

            }
            loop = false;

            Console.Write("\n\nPlease press ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("ENTER");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" to continue.");

            Console.ReadLine();
            Console.Clear();

            Spices oregano = new Spices(659, 30);
            Spices basil = new Spices(720, 35);
            Spices parsley = new Spices(626, 30);
            Spices thyme = new Spices(525, 25);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(money);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("$.");

            Console.Write("\n\nFINALLY, you will have to buy your ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("SPICES");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" (Kids, don't do drugs).");

            List<string> spicesList = new List<string>() { "[a] OREGANO - " + oregano.price + "$", "[b] BASIL - " + basil.price + "$", "[c] PARSLEY - " + parsley.price + "$", "[d] THYME - " + thyme.price + "$" };
            Console.Write("\n\n\n");
            spicesList.ForEach(Console.WriteLine);

            loop = true;

            while (loop)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A:
                        //OREGANO
                        money = money - oregano.price;

                        Console.Write("\n\nYou chose OREGANO. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(oregano);

                        break;

                    case ConsoleKey.B:
                        //BASIL
                        money = money - basil.price;

                        Console.Write("\n\nYou chose BASIL. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(basil);

                        break;

                    case ConsoleKey.C:
                        //PARSLEY
                        money = money - parsley.price;

                        Console.Write("\n\nYou chose PARSLEY. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(parsley);

                        break;

                    case ConsoleKey.D:
                        //THYME
                        money = money - thyme.price;

                        Console.Write("\n\nYou chose THYME. You now have ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(money);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("$ left.");

                        loop = false;
                        ingredients.Add(thyme);

                        break;

                    default:

                        Console.Write("\nPlease choose one of the following:\n\n");
                        vegetablesList.ForEach(Console.WriteLine);

                        break;
                }
                loop = false;
            }

            return ingredients;
        }
    }
}