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
        public Day()
        {
        }
        Weather currentDay = new Weather();
        Customer tempCustomer = new Customer();
        public int getNumberOfCustomers()
        {
            Random random = new Random();
            if (currentDay.weather == "sunny")
            {
                int numberOfCustomers = random.Next(100, 150);
                return numberOfCustomers;
            }
            else if (currentDay.weather == "cloudy")
            {
                int numberOfCustomers = random.Next(80, 130);
                return numberOfCustomers;
            }
            else if (currentDay.weather == "rainy")
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
        public void setAllCustomers()
        {
            int numberOfCustomers = getNumberOfCustomers();
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customer tempCustomer = new Customer();

            }
        }
    }
}
