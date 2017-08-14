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
        public double cupPrice;
        double totalMoneyForDay;
        public Weather currentWeather = new Weather();
        Customer tempCustomer;
        Player player;
        UserInterface UI;
        public Day()
        {
        }
        private int GetNumberOfCustomers()
        {
            Random random = new Random();
            if (currentWeather.weather == "sunny")
            {
                int numberOfCustomers = random.Next(100, 150);
                return numberOfCustomers;
            }
            else if (currentWeather.weather == "cloudy")
            {
                int numberOfCustomers = random.Next(80, 130);
                return numberOfCustomers;
            }
            else if (currentWeather.weather == "rainy")
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
        private void DisplayEndOfDayResults()
        {
            Console.WriteLine($"You have sold {cupsSold} cups and now have a total of ${player.playerMoney} for a total {CheckLossOrProfit()} of ${GetTotalDifference()}");
            Console.ReadLine();
            UI.MainMenu();
        }
        private void SetAllCustomers()
        {
            int numberOfCustomers = GetNumberOfCustomers();
            for (int i = 0; i < numberOfCustomers; i++)
            {
             tempCustomer = new Customer();
                tempCustomer.CallAllMethodsCustomer();
                CheckPitchersSold();
            }
        }
        public void CallAllMethodsDay()
        {
            SetAllCustomers();
            GetToalAmountSold();
            CheckLossOrProfit();
            GetTotalDifference();
            DisplayEndOfDayResults();
        }
    }
}
