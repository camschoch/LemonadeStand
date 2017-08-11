using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public Weather()
        {
        }
        //public string todaysWeather;
        public string weather;
        public int temp;

        public void GetWeatherForcast()
        {
            weather = RandomWeather();
            temp = GetRandomTemp();
        }
        public void ActualWeather()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            List<string> weatherType = new List<string>() {"yes", "no"};
            string todaysWeather = weatherType[randomNumber];
            if(todaysWeather == "no")
            {
                weather = RandomWeather();
                temp = GetRandomTemp();
            }
        }
        public string RandomWeather()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            List<string> weatherType = new List<string>() { "sunny", "cloudy", "rainy" };
            string todaysWeather = weatherType[randomNumber];
            return todaysWeather;
        }

        public int GetRandomTemp()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            List<int> weatherType = new List<int>() { 65, 75, 90 };
            int temp = weatherType[randomNumber];
            return temp;
        }
       
    }
}
