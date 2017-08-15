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
                    AddOneLemon(player);
                    SubtractTenCent(player);
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "5":
                    AddFiveLemon(player);
                    player.playerMoney -= .50;
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "10":
                    player.inventory.NumberOfLemon += 10;
                    player.playerMoney -= 1;
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
        public void AddOneLemon(Player player)
        {
            player.inventory.NumberOfLemon++;
        }
        public void AddFiveLemon(Player player)
        {
            player.inventory.NumberOfLemon += 5;
        }
        public void AddTenLemon(Player player)
        {
            player.inventory.NumberOfLemon += 10;
        }
        public void AddOneSugar(Player player)
        {
            player.inventory.NumberOfSugar++;
        }
        public void AddFiveSugar(Player player)
        {
            player.inventory.NumberOfSugar += 5;
        }
        public void AddTenSugar(Player player)
        {
            player.inventory.NumberOfSugar += 10;
        }
        public void SubtractTenCent(Player player)
        {
            player.playerMoney -= .10;
        }
        public void BuySugar(Player player, Game game, Day currentDay, Weather CurrentWeather, UserInterface UI)
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    player.inventory.NumberOfSugar++;
                    player.playerMoney -= .10;
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "5":
                    player.inventory.NumberOfSugar += 5;
                    player.playerMoney -= .50;
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "10":
                    player.inventory.NumberOfSugar += 10;
                    player.playerMoney -= 1;
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
                    player.inventory.NumberOfIce += 10;
                    player.playerMoney -= .10;
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "50":
                    player.inventory.NumberOfIce += 50;
                    player.playerMoney -= .50;
                    UI.PlayerStoreOptions(player, game, currentDay, CurrentWeather, UI);
                    break;
                case "100":
                    player.inventory.NumberOfIce += 100;
                    player.playerMoney -= 1;
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
    }
}
