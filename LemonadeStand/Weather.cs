using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public string weather;
        public int temp;
        public Weather()
        {
        }
        //public string todaysWeather;

        public void GetWeatherForcast(Random random)
        {
            weather = RandomWeather(random);
            temp = GetRandomTemp(random);
        }
        public void ActualWeather(Random random)
        {
            
            int randomNumber = random.Next(0, 2);
            List<string> weatherType = new List<string>() {"yes", "no"};
            string todaysWeather = weatherType[randomNumber];
            if(todaysWeather == "no")
            {
                weather = RandomWeather(random);
                temp = GetRandomTemp(random);
            }
        }
        public string RandomWeather(Random random)
        {
           
            int randomNumber = random.Next(0, 3);
            List<string> weatherType = new List<string>() { "sunny", "cloudy", "rainy" };
            string todaysWeather = weatherType[randomNumber];
            return todaysWeather;
        }

        public int GetRandomTemp(Random random)
        {
            
            int randomNumber = random.Next(0, 3);
            List<int> weatherType = new List<int>() { 65, 75, 90 };
            int temp = weatherType[randomNumber];
            return temp;
        }
       
    }
}
