using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class UserInterface
    {
        Player player;
        Store store;
        public void chooseRecipe()
        {
            Console.WriteLine("Please choose a recipe you would like to make for the day. (type 1, 2, 3, or 4)");
            Console.WriteLine("1 = 4 lemons and 4 sugar cubes per pitcher for a standard taste.");
            Console.WriteLine("2 = 8 lemons and 4 sugar cubes per pitcher for a sour taste.");
            Console.WriteLine("3 = 4 lemons and 8 sugar cubes per pitcher for a sweet taste.");
            Console.WriteLine("4 = 8 lemons and 8 sugar cubes per pitcher for a strong taste.");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    player.recipe = "standard";
                    player.amountOfLemonNeeded = 4;
                    player.amountOfSugarNeeded = 4;
                    break;
                case "2":
                    player.recipe = "sour";
                    player.amountOfLemonNeeded = 8;
                    player.amountOfSugarNeeded = 4;
                    break;
                case "3":
                    player.recipe = "sweet";
                    player.amountOfLemonNeeded = 4;
                    player.amountOfSugarNeeded = 8;
                    break;
                case "4":
                    player.recipe = "strong";
                    player.amountOfLemonNeeded = 8;
                    player.amountOfSugarNeeded = 8;
                    break;
                default:
                    chooseRecipe();
                    break;
            }
            SetNumberOfPitchers();
        }
        public void SetNumberOfPitchers()
        {
            Console.WriteLine("How many pitchers would you like to make for the day? Max is 7.");
            player.SwitchCallNumberOfPitchers();
        }
        //BEGIN OF STORE INTERACTION//
        public void PlayerStoreOptions()
        {
            Console.WriteLine("Welcome to the store what would you like to buy?\n1 = Lemons\n2 = Sugar\n3 = Ice\n4 = Leave store");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    BuyLemonsPrompt();
                    break;
                case "2":
                    BuySugar();
                    break;
                case "3":
                    BuyIce();
                    break;
                case "4":
                    //////////////////DIRECT PLAYER TO MAIN MENU
                    break;
                default:
                    PlayerStoreOptions();
                    break;
            }
        }
        public void BuyLemonsPrompt()
        {
            Console.WriteLine("How many lemons would you like to buy?\n1= $0.10\n5 = $0.50\n10 = $1 (type leave if you don't want to buy)");
            store.BuyLemons();

        }
        public void BuySugar()
        {
            Console.WriteLine("How many sugar cubes would you like to buy?\n1= $0.10\n5 = $0.50\n10 = $1 (type leave if you don't want to buy)");
            store.BuyLemons();
        }
        public void BuyIce()
        {
            Console.WriteLine("How many ice cubes would you like to buy?\n10= $0.10\n50 = $0.50\n100 = $1 (type leave if you don't want to buy)");
            store.BuyLemons();
        }
    }
    //END OF STORE INTERACTION//
}
