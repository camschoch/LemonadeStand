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
        public Weather currentWeather = new Weather();
        public Day()
        {
        }
        public int getNumberOfCustomers()
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
        //public void setAllCustomers()
        //{
        //    int numberOfCustomers = getNumberOfCustomers();
        //    for (int i = 0; i < numberOfCustomers; i++)
        //    {

        //    }
        //}
    }
}
