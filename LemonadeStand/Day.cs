﻿using System;
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
        public Weather currentWeather = new Weather();
        public Customer tempCustomer;
        public Day()
        {
        }
        public int GetNumberOfCustomers()
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
        public void SetAllCustomers()
        {
            int numberOfCustomers = GetNumberOfCustomers();
            for (int i = 0; i < numberOfCustomers; i++)
            {
             tempCustomer = new Customer();
                tempCustomer.CallAllMethods();

            }
        }
    }
}
