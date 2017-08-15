using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        //UserInterface UI;
        // Inventory inventory;
        public void BuyLemons(Player player, Game game, Day currentDay, Weather CurrentWeather, UserInterface UI)
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    AddLemons(player, 1);
                    SubtractMoney(player, .10);
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "5":
                    AddLemons(player, 5);
                    SubtractMoney(player, .50);
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "10":
                    AddLemons(player, 10);
                    SubtractMoney(player, 1);
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "leave":
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                default:
                    Console.WriteLine("Sorry that wasn't an option please try again.");
                    Console.ReadLine();
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
            }

        }
       
        public void BuySugar(Player player, Game game, Day currentDay, Weather CurrentWeather, UserInterface UI)
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    AddSugar(player, 1);
                    SubtractMoney(player, .10);
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "5":
                    AddSugar(player, 5);
                    SubtractMoney(player, .50);
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "10":
                    AddSugar(player, 10);
                    SubtractMoney(player, 1);
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "leave":
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                default:
                    Console.WriteLine("Sorry that wasn't an option please try again.");
                    Console.ReadLine();
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
            }

        }
        public void BuyIce(Player player, Game game, Day currentDay, Weather CurrentWeather, UserInterface UI)
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "10":
                    AddIce(player, 10);
                    SubtractMoney(player, .10);
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "50":
                    AddIce(player, 50);
                    SubtractMoney(player, .50);
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "100":
                    AddIce(player, 100);
                    SubtractMoney(player, 1);
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "leave":
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                default:
                    Console.WriteLine("Sorry that wasn't an option please try again.");
                    Console.ReadLine();
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
            }
        }
        public void AddLemons(Player player, int amount)
        {
            player.inventory.NumberOfLemon += amount;
        }
        public void AddSugar(Player player, int amount)
        {
            player.inventory.NumberOfSugar += amount;
        }
        public void AddIce(Player player, int amount)
        {
            player.inventory.NumberOfIce += amount;
        }
        public void SubtractMoney(Player player, double amount)
        {
            player.playerMoney -= amount;
        }
    }
}
