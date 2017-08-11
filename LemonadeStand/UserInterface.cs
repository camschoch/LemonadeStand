using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {
        Player player;
        //Console.WriteLine("This game is called Lemonade Stand and here's how to play!\n You will see the weather forcast for both the week and the day. Weather will effect your sales for that day but be carful the weekly isn't alawys accurate.\nYou will have a limited amount of starting money and will have to buy your ingredients to keep your stand running.");
        //        Console.ReadLine();


        public void chooseRecipe()
        {
            Console.WriteLine("Please choose a recipe you would like to make for the day. (type 1, 2, 3, or 4)");
            Console.WriteLine("1 = 4 lemons and 4 sugar cubes for a standard taste.");
            Console.WriteLine("2 = 8 lemons and 4 sugar cubes for a sour taste.");
            Console.WriteLine("3 = 4 lemons and 8 sugar cubes for a sweet taste.");
            Console.WriteLine("4 = 8 lemons and 8 sugar cubes for a strong taste.");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    player.recipe = "standard";
                    break;
                case "2":
                    player.recipe = "sour";
                    break;
                case "3":
                    player.recipe = "sweet";
                    break;
                case "4":
                    player.recipe = "strong";
                    break;
            }
        }
    }
}
