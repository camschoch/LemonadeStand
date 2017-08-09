using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        int thirstLvl;
        Day currentDay = new Day();
        string weatherpattern = currentDay.currentWeather.weather;
        
        public Customer()
        {
        }
        public int getWeatherThirst()
        {
            Random random = new Random();
            if (weather == "sunny")
            {
                cue
                int randomNumber = random.Next(40, 85);
                int thirstLvl = randomNumber;
                return thirstLvl;
            }
            else if (weather == "cloudy")
            {
                int randomNumber = random.Next(60, 95);
                int thirstLvl = randomNumber;
                return thirstLvl;
            }
            else if (weather == "rainy")
            {
                int randomNumber = random.Next(70, 100);
                int thirstLvl = randomNumber;
                return thirstLvl;
            }
            else
            {
                int failSafe = 75;
                return failSafe;
            }
        }
        public int calculateThirst()
        {
            int weatherThirst = getWeatherThirst();
            if (temp == 65)
            {
                weatherThirst += 10;
                return weatherThirst;
            }
            else if (temp == 75)
            {
                weatherThirst -= 5;
                return weatherThirst;
            }
            else if (temp == 90)
            {
                weatherThirst -= 15;
                return weatherThirst;
            }
            else
            {
                weather += 0;
                return weatherThirst;
            }
        }
        public void
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
}
