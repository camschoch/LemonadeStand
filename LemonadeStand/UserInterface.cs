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
        Weather weather;
        Day currentDay;

        //MAIN MENU//
        public void MainMenu()
        {
            Console.WriteLine("Welcome to the main menu. Would you like to visit the store, check the weather forcast, or start your day? (make sure you have the supplies you need to make lemonade for the day).");
            Console.WriteLine("1 = visit store\n 2 = check forcast\n 3 = start the day.");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    PlayerStoreOptions();
                    break;
                case "2":
                    Console.WriteLine("the forcast for today is " + weather.weather + "and " + weather.temp + "degrees.");
                    break;
                case "3":
                    Console.WriteLine("You are now begining day number " + currentDay.dayNumber);
                    Console.ReadLine();
                    ChooseRecipe();
                    break;
                default:
                    Console.WriteLine("Sorry we didn't understand please try again.");
                    MainMenu();
                    break;
            }
        }


        //END MAIN MENU//
        //CHOOSING LEMONADE//
        public void ChooseRecipe()
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
                    ChooseRecipe();
                    break;
            }
            SetAmmountOfIce();
            SetNumberOfPitchers();
        }
        public void SetAmmountOfIce()
        {
            Console.WriteLine("How much ice would you like to add to each cup sold?");
            Console.WriteLine("2 = 2 ice per cup for a total of 16 needed to make a pitcher\n4 = 4 ice per cup for a total of 31 needed to make a pitcher\n8 = 8 ice per cup for a total of 64 needed to make a pitcher\n");
            player.amountOfIceNeededPerCup = int.Parse(Console.ReadLine());
        }
        public void SetNumberOfPitchers()
        {
            Console.WriteLine("How many pitchers would you like to make for the day? Max is 7.");
            player.SetAmountOfIceNeededPerPitcher();
            player.SwitchCallNumberOfPitchers();
        }
        public void SetPriceForDay()
        {
            Console.WriteLine("How much would you like to sell each cup for today? (ex. 1.25 or .50)");
            //USE THE TRY CATCH TO MAKE SURE USER INPUTS A NUMBER VALUE//
            string userSetCupPrice = Console.ReadLine();
            currentDay.cupPrice = Double.Parse(userSetCupPrice);
        }
        //END CHOOSING LEMONADE//
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
                    BuySugarPrompt();
                    break;
                case "3":
                    BuyIcePrompt();
                    break;
                case "4":
                    MainMenu();
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
        public void BuySugarPrompt()
        {
            Console.WriteLine("How many sugar cubes would you like to buy?\n1= $0.10\n5 = $0.50\n10 = $1 (type leave if you don't want to buy)");
            store.BuyLemons();
        }
        public void BuyIcePrompt()
        {
            Console.WriteLine("How many ice cubes would you like to buy?\n10= $0.10\n50 = $0.50\n100 = $1 (type leave if you don't want to buy)");
            store.BuyLemons();
        }
    }
    //END OF STORE INTERACTION//
}
