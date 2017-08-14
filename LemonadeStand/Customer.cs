using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        Weather currentWeather;
        Day currentDay;
        Player player;
        public int thirstLvl;
        public double maxBuyPrice;
        int likelinessToBuy = 50;
        string customerPreferedRecipe;
        int wantedIce;
        public Customer()
        {
        }
        private void GetWeatherThirst()
        {

            Random random = new Random();
            string weather = currentWeather.weather;
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
        private void CalculateThirst()
        {
            int temp = currentWeather.temp;
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
        private void LikenessToBuyIce()
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
        private void LikenessToBuyTaste()
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
        private void LikenessToBuyPrice()
        {
            if (currentDay.cupPrice <= maxBuyPrice)
            {
                likelinessToBuy += 15;
            }
            else if (currentDay.cupPrice >= maxBuyPrice + 2)
            {
                likelinessToBuy = 0;
            }
            else if (currentDay.cupPrice >= maxBuyPrice)
            {
                likelinessToBuy -= 15;
            }
        }
        private void WillOrNotBuy()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            if (randomNumber <= likelinessToBuy)
            {
                currentDay.cupsSold++;
            }
        }
        public void CallAllMethods()
        {
            GetWeatherThirst();
            CalculateThirst();
            LikenessToBuyThirstLvl();
            SetPreferedIce();
            LikenessToBuyIce();
            PreferedRecipe();
            LikenessToBuyTaste();
            SetRandomBuyMax(0.50, 1.50);
            LikenessToBuyPrice();
            WillOrNotBuy();
        }
    }
}
