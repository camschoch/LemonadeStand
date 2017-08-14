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
        public Customer(int thirstLvl)
        {
            this.thirstLvl = thirstLvl;
        }
        public void GetWeatherThirst()
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
        public void CalculateThirst()
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

        public void WillOrNotBuy()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            if(randomNumber <= likelinessToBuy)
            {
                currentDay.cupsSold++;
            }
        }
        public void SetRandomBuyMax(double minValue, double maxValue)
        {
            Random random = new Random();
            double next = random.NextDouble();

            double unRounded = minValue + (next * (maxValue - minValue));
            double rounded = Math.Round(unRounded, 2);
            maxBuyPrice = rounded;
            //////////////REMEMBER TO SET THE RANGE WHEN CALLING THE METHOD!!!
        }

        public void PreferedRecipe()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 7);
            List<string> recipies = new List<string> { "standard", "sour", "sweet", "strong", "strong", "strong", "strong"};
            string randomRecipe = recipies[randomNumber];
            //NOT YET COMPLETE//
        }
        private void LikenessToBuyThirstLvl()
        {
            if (thirstLvl >= 50)
            {
                likelinessToBuy += 15;
            }
            else if (thirstLvl < 50 && thirstLvl >= 80)
            {
                likelinessToBuy += 0;
            }
            else if (thirstLvl <= 100)
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

        //public void buyOrNo()
        //{
        //    Random random = new Random();
        //    int randomNumber = random.Next(0, 2);
        //    List<string> willBuy = new List<string>() { "yes", "no" };
        //    string yesOrNo = willBuy [randomNumber];
        //    if (yesOrNo == "yes")
        //    {
        //        cupsSold++;
        //    }
    }
}
