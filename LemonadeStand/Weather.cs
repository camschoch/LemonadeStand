using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        public Weather()
        {

        }
        public string todaysWather;
        public void randomWeather()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            List<string> weatherType = new List<string>() { "sunny", "cloudy", "rainy" };
            todaysWather = weatherType[randomNumber];
        }

        public int getRandomTemp()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            List<int> weatherType = new List<int>() { 65, 75, 90 };
            int temp = weatherType[randomNumber];
            return temp;
        }
        public int getWeatherThirst()
        {
            Random random = new Random();
            if (todaysWather == "sunny")
            {
                int randomNumber = random.Next(40, 85);
                int thirstLvl = randomNumber;
                return thirstLvl;
            }
            else if (todaysWather == "cloudy")
            {
                int randomNumber = random.Next(60, 95);
                int thirstLvl = randomNumber;
                return thirstLvl;
            }
            else if (todaysWather == "rainy")
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
            int temp = getRandomTemp();
            int weather = getWeatherThirst();
            if (temp == 65)
            {
                weather += 10;
                return weather;
            }
            else if (temp == 75)
            {
                weather -= 5;
                return weather;
            }
            else if (temp == 90)
            {
                weather -= 15;
                return weather;
            }
            else
            {
                weather += 0;
                return weather;
            }
        }
    }
}
