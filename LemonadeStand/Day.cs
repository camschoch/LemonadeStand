using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        public int cupsSold = 0;
        public int dayNumber = 1;
        public double cupPrice;
        double totalMoneyForDay;
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
        private void CheckPitchersSold()
        {
            if(cupsSold % 8 == 0 && cupsSold != 0)
            {
                player.pitchers -= 1;
            }
            if(player.pitchers == 0)
            {
                Console.WriteLine("You have run out of lemoande for the day");
                Console.ReadLine();
                //DISPLAY END OF DAY RESULTS//
            }
        }
        private void GetToalAmountSold()
        {
            totalMoneyForDay = cupsSold * cupPrice;
        }
        private string CheckLossOrProfit()
        {
            if(totalMoneyForDay > player.playerMoney)
            {
                string profit = "profit";
                return profit;
            }
            else
            {
                string loss = "loss";
                return loss;
            }
        }
        private double GetTotalDifference()
        {
            double totalDifference = totalMoneyForDay - player.playerMoney;
            return totalDifference;
        }
        private void DisplayEndOfDayResults(Player player, Game game, Day currentDay, Weather CurrentWeather)
        {
            Console.WriteLine($"You have sold {cupsSold} cups and now have a total of ${player.playerMoney} for a total {CheckLossOrProfit()} of ${GetTotalDifference()}");
            Console.ReadLine();
            UI.MainMenu(player, game, currentDay, CurrentWeather, UI);
        }
        private void SetAllCustomers(Player player, Day currentDay, Weather CurrentWeather)
        {
            int numberOfCustomers = GetNumberOfCustomers();
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customer tempCustomer = new Customer();
                tempCustomer.CallAllMethodsCustomer(player, currentDay, CurrentWeather);
                CheckPitchersSold();
            }
        }
        public void CallAllMethodsDay(Player player, Game game, Day currentDay, Weather CurrentWeather)
        {
            SetAllCustomers(player, currentDay, CurrentWeather);
            GetToalAmountSold();
            CheckLossOrProfit();
            GetTotalDifference();
            DisplayEndOfDayResults(player, game, currentDay, CurrentWeather);
        }
    }
}
