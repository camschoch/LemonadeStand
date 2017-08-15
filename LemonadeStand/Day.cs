using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public int cupsSold = 0;
        public int dayNumber = 1;
        
        public double totalMoneyForDay;
        Weather CurrentWeather;
        Player player;
        UserInterface UI;
        public Day(Player player, UserInterface UI, Weather CurrentWeather)
        {
            this.player = player;
            this.UI = UI;
            this.CurrentWeather = CurrentWeather;
        }
        private int GetNumberOfCustomers()
        {
            Random random = new Random();
            if (CurrentWeather.weather == "sunny")
            {
                int numberOfCustomers = random.Next(100, 150);
                return numberOfCustomers;
            }
            else if (CurrentWeather.weather == "cloudy")
            {
                int numberOfCustomers = random.Next(80, 130);
                return numberOfCustomers;
            }
            else if (CurrentWeather.weather == "rainy")
            {
                int numberOfCustomers = random.Next(50, 100);
                return numberOfCustomers;
            }
            else
            {
                int numberOfCustomers = random.Next(80, 120);
                return numberOfCustomers;
            }
        }
        private void CheckPitchersSold(Game game, Day currentDay)
        {
            if(cupsSold % 8 == 0 && cupsSold != 0)
            {
                player.pitchers -= 1;
            }
            else if(player.pitchers == 0)
            {
                GetToalAmountSold(player);
                player.playerMoney += totalMoneyForDay;
                Console.WriteLine("You have run out of lemoande for the day.");
                DisplayEndOfDayResults(player, game, currentDay, CurrentWeather);
                UI.MainMenu(player, game, currentDay, CurrentWeather, UI);
            }
        }
        public void GetToalAmountSold(Player player)
        {
            totalMoneyForDay = cupsSold * player.cupPrice;
        }
        private void DisplayEndOfDayResults(Player player, Game game, Day currentDay, Weather CurrentWeather)
        {
            Console.WriteLine($"You have sold {cupsSold} cups and now have a total of ${player.playerMoney}");
            Console.ReadLine();
            UI.MainMenu(player, game, currentDay, CurrentWeather, UI);
        }
        private void SetAllCustomers(Player player, Game game, Day currentDay, Weather CurrentWeather)
        {
            int numberOfCustomers = GetNumberOfCustomers();
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customer tempCustomer = new Customer();
                tempCustomer.CallAllMethodsCustomer(player, currentDay, CurrentWeather);
                CheckPitchersSold(game, currentDay);
            }
        }
        public void CallAllMethodsDay(Player player, Game game, Day currentDay, Weather CurrentWeather)
        {
            SetAllCustomers(player, game, currentDay, CurrentWeather);
            GetToalAmountSold(player);
            player.playerMoney += totalMoneyForDay;
            DisplayEndOfDayResults(player, game, currentDay, CurrentWeather);
        }
    }
}
