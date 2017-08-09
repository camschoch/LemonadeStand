﻿using System;
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
        //public string todaysWeather;
        public string weather;
        public int temp;

        public void getWeatherForcast()
        {
            weather = randomWeather();
            temp = getRandomTemp();
        }
        public void actualWeather()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            List<string> weatherType = new List<string>() {"yes", "no"};
            string todaysWeather = weatherType[randomNumber];
            if(todaysWeather == "no")
            {
                weather = randomWeather();
                temp = getRandomTemp();
            }
        }
        public string randomWeather()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            List<string> weatherType = new List<string>() { "sunny", "cloudy", "rainy" };
            string todaysWeather = weatherType[randomNumber];
            return todaysWeather;
        }

        public int getRandomTemp()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            List<int> weatherType = new List<int>() { 65, 75, 90 };
            int temp = weatherType[randomNumber];
            return temp;
        }
        //public int getWeatherThirst()
        //{
        //    Random random = new Random();
        //    if (weather == "sunny")
        //    {
        //        int randomNumber = random.Next(40, 85);
        //        int thirstLvl = randomNumber;
        //        return thirstLvl;
        //    }
        //    else if (weather == "cloudy")
        //    {
        //        int randomNumber = random.Next(60, 95);
        //        int thirstLvl = randomNumber;
        //        return thirstLvl;
        //    }
        //    else if (weather == "rainy")
        //    {
        //        int randomNumber = random.Next(70, 100);
        //        int thirstLvl = randomNumber;
        //        return thirstLvl;
        //    }
        //    else
        //    {
        //        int failSafe = 75;
        //        return failSafe;
        //    }
        //}
        //public int calculateThirst()
        //{
        //    int weatherThirst = getWeatherThirst();
        //    if (temp == 65)
        //    {
        //        weatherThirst += 10;
        //        return weatherThirst;
        //    }
        //    else if (temp == 75)
        //    {
        //        weatherThirst -= 5;
        //        return weatherThirst;
        //    }
        //    else if (temp == 90)
        //    {
        //        weatherThirst -= 15;
        //        return weatherThirst;
        //    }
        //    else
        //    {
        //        weather += 0;
        //        return weatherThirst;
        //    }
        //}
    }
}
