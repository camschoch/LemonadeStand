using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class UserInterface
    {
        //Day currentDay;
        //Weather CurrentWeather;
        int dayNumber = 1;
        public UserInterface()
        {
        }
        //MAIN MENU//
        public void MainMenu(Player player, Game game, Day currentDay, Weather CurrentWeather, UserInterface UI)
        {
            Console.WriteLine("Welcome to the main menu. Would you like to visit the store, check the weather forcast, or start your day? (make sure you have the supplies you need to make lemonade for the day).");
            Console.WriteLine("1 = visit store\n2 = check forcast\n3 = start the day\n4 = check inventory\n5 = quit game");
            string userInput = Console.ReadLine();
            if(dayNumber == 8)
            {
                Console.WriteLine($"You have reached the end of the week! You have a total of ${player.playerMoney}");
                Console.WriteLine("Thank you for playing!");
                Console.ReadLine();
                return;
            }
            switch (userInput)
            {
                case "1":
                    PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "2":
                    Console.WriteLine("the forcast for today is " + CurrentWeather.weather + " and " + CurrentWeather.temp + " degrees.");
                    Console.ReadLine();
                    MainMenu(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "3":
                    Console.WriteLine("You are now begining day number " + dayNumber);
                    Console.ReadLine();
                    dayNumber += 1;
                    game.StartPlayerSetup(player, game, currentDay, CurrentWeather, UI);
                    game.StartDay(game);
                    break;
                case "4":
                    Console.WriteLine($"You have {player.inventory.NumberOfLemon} lemons, {player.inventory.NumberOfSugar} sugar cubes, and {player.inventory.NumberOfIce} ice cubes");
                    Console.WriteLine($"You have ${player.playerMoney}");
                    Console.ReadLine();
                    MainMenu(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "5":
                    Console.WriteLine("Thanks for playing!");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Sorry we didn't understand please try again.");
                    MainMenu(player, game, currentDay, CurrentWeather, UI);
                    break;
            }
        }


        //END MAIN MENU//
        //CHOOSING LEMONADE//
        public void ChooseRecipe(Player player)
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
                    ChooseRecipe(player);
                    break;
            }
        }
        private void SetAmmountOfIce(Player player)
        {
            Console.WriteLine("How much ice would you like to add to each cup sold?");
            Console.WriteLine("2 = 2 ice per cup for a total of 16 needed to make a pitcher\n4 = 4 ice per cup for a total of 31 needed to make a pitcher\n8 = 8 ice per cup for a total of 64 needed to make a pitcher\n");
            player.amountOfIceNeededPerCup = int.Parse(Console.ReadLine());
        }
        private void SetNumberOfPitchers(Player player, Game game, Day currentDay, Weather CurrentWeather, UserInterface UI)
        {
            Console.WriteLine("How many pitchers would you like to make for the day? Max is 7.");
            player.SetAmountOfIceNeededPerPitcher();
            player.SwitchCallNumberOfPitchers(player, game, currentDay, CurrentWeather, UI);
        }
        private void SetPriceForDay(Player player)
        {
            Console.WriteLine("How much would you like to sell each cup for today? (ex. 1.25 or .50)");
            //USE THE TRY CATCH TO MAKE SURE USER INPUTS A NUMBER VALUE//
            string userSetCupPrice = Console.ReadLine();
            double test = double.Parse(userSetCupPrice);
            player.cupPrice = test;
        }
        public void CallAllChoosingLemonade(Player player, Game game, Day currentDay, Weather CurrentWeather, UserInterface UI)
        {
            ChooseRecipe(player);
            SetAmmountOfIce(player);
            SetNumberOfPitchers(player, game, currentDay, CurrentWeather, UI);
            SetPriceForDay(player);
        }
        //END CHOOSING LEMONADE//
        //BEGIN OF STORE INTERACTION//
        public void PlayerStoreOptions(Player player, Game game, Day currentDay, Weather CurrentWeather, UserInterface UI)
        {
            Console.WriteLine("Welcome to the store what would you like to buy?\n1 = Lemons\n2 = Sugar\n3 = Ice\n4 = Leave store");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    BuyLemonsPrompt(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "2":
                    BuySugarPrompt(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "3":
                    BuyIcePrompt(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "4":
                    MainMenu(player, game, currentDay, CurrentWeather, UI);
                    break;
                default:
                    Console.WriteLine("Sorry please try again.");
                    Console.ReadLine();
                    PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
            }
        }
        public void BuyLemonsPrompt(Player player, Game game, Day currentDay, Weather CurrentWeather, UserInterface UI)
        {
            Console.WriteLine("How many lemons would you like to buy?\n1= $0.10\n5 = $0.50\n10 = $1\n(type leave if you don't want to buy)");
            player.store.BuyLemons(player, game, currentDay, CurrentWeather, UI);

        }
        public void BuySugarPrompt(Player player, Game game, Day currentDay, Weather CurrentWeather, UserInterface UI)
        {
            Console.WriteLine("How many sugar cubes would you like to buy?\n1= $0.10\n5 = $0.50\n10 = $1\n(type leave if you don't want to buy)");
            player.store.BuySugar(player, game, currentDay, CurrentWeather, UI);
        }
        public void BuyIcePrompt(Player player, Game game, Day currentDay, Weather CurrentWeather, UserInterface UI)
        {
            Console.WriteLine("How many ice cubes would you like to buy?\n10= $0.10\n50 = $0.50\n100 = $1\n(type leave if you don't want to buy)");
            player.store.BuyIce(player, game, currentDay, CurrentWeather, UI);
        }
    }
    //END OF STORE INTERACTION//
}
