using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        
        //Weather currentWeather;
        //Day currentDay;
        //Player player;
        public int thirstLvl;
        public double maxBuyPrice;
        int likelinessToBuy = 50;
        string customerPreferedRecipe;
        int wantedIce;
        public Customer()
        {
        }
        private void GetWeatherThirst(Weather CurrentWeather)
        {
            
            Random random = new Random();
            string weather = CurrentWeather.weather;
            if (weather == "sunny")
            {

                int randomNumber = random.Next(30, 50);
                int thirstLvlTest = randomNumber;
                thirstLvl = thirstLvlTest;
            }
            else if (weather == "cloudy")
            {
                int randomNumber = random.Next(50, 80);
                int thirstLvlTest = randomNumber;
                thirstLvl = thirstLvlTest;
            }
            else if (weather == "rainy")
            {
                int randomNumber = random.Next(80, 100);
                int thirstLvlTest = randomNumber;
                thirstLvl = thirstLvlTest;
            }
        }
        private void CalculateThirst(Weather CurrentWeather)
        {
            int temp = CurrentWeather.temp;
            int weatherThirst = thirstLvl;
            if (temp == 65)
            {
                weatherThirst += 20;
                thirstLvl = weatherThirst;
            }
            else if (temp == 75)
            {
                weatherThirst -= 10;
                thirstLvl = weatherThirst;
            }
            else if (temp == 90)
            {
                weatherThirst -= 20;
                thirstLvl = weatherThirst;
            }
            else
            {
                weatherThirst += 0;
                thirstLvl = weatherThirst;
            }
        }
        private void SetPreferedIce()
        {
            if (thirstLvl <= 50)
            {
                wantedIce += 8;
            }
            else if (thirstLvl > 50 && thirstLvl <= 80)
            {
                wantedIce += 4;
            }
            else if (thirstLvl <= 100)
            {
                wantedIce += 2;
            }
        }

        private void SetRandomBuyMax(double minValue, double maxValue)
        {
            Random random = new Random();
            double next = random.NextDouble();

            double unRounded = minValue + (next * (maxValue - minValue));
            double rounded = Math.Round(unRounded, 2);
            maxBuyPrice = rounded;
        }

        private void PreferedRecipe()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 7);
            List<string> recipies = new List<string> { "standard", "sour", "sweet", "strong", "strong", "strong", "strong" };
            customerPreferedRecipe = recipies[randomNumber];
        }
        private void LikenessToBuyIce(Player player)
        {
            if(player.amountOfIceNeededPerCup == wantedIce)
            {
                likelinessToBuy += 10;
            }
            else if (player.amountOfIceNeededPerCup != wantedIce)
            {
                likelinessToBuy -= 10;
            }
        }
        private void LikenessToBuyTaste(Player player)
        {
            if (player.recipe == "sour" || player.recipe == "sweet" && customerPreferedRecipe == "standard" || customerPreferedRecipe == "strong")
            {
                likelinessToBuy += 0;
            }
            else if (player.recipe == customerPreferedRecipe)
            {
                likelinessToBuy += 15;
            }
            else if (player.recipe == "standard" && customerPreferedRecipe == "strong")
            {
                likelinessToBuy -= 15;
            }
            else if (player.recipe == "strong" && customerPreferedRecipe == "standard")
            {
                likelinessToBuy -= 15;
            }
        }
        private void LikenessToBuyThirstLvl()
        {
            if (thirstLvl <= 50)
            {
                likelinessToBuy += 15;
            }
            else if (thirstLvl > 50 && thirstLvl <= 80)
            {
                likelinessToBuy += 0;
            }
            else if (thirstLvl >= 100)
            {
                likelinessToBuy -= 15;
            }
        }
        private void LikenessToBuyPrice(Player player)
        {
            if (player.cupPrice <= maxBuyPrice)
            {
                likelinessToBuy += 15;
            }
            else if (player.cupPrice >= maxBuyPrice + 2)
            {
                likelinessToBuy = 0;
            }
            else if (player.cupPrice >= maxBuyPrice)
            {
                likelinessToBuy -= 15;
            }
        }
        private void WillOrNotBuy(Day currentDay)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            if (randomNumber <= likelinessToBuy)
            {
                currentDay.cupsSold++;
            }
        }
        public void CallAllMethodsCustomer(Player player, Day currentDay, Weather CurrentWeather)
        {
            GetWeatherThirst(CurrentWeather);
            CalculateThirst(CurrentWeather);
            LikenessToBuyThirstLvl();
            SetPreferedIce();
            LikenessToBuyIce(player);
            PreferedRecipe();
            LikenessToBuyTaste(player);
            SetRandomBuyMax(0.50, 1.50);
            LikenessToBuyPrice(player);
            WillOrNotBuy(currentDay);
        }
    }
}
