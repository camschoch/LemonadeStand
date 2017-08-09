using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public Day()
        {
        }
        Weather currentDay = new Weather();
        public int getNumberOfCustomers()
        {
            Random random = new Random();
            if (currentDay.todaysWather == "sunny")
            {
                int numberOfCustomers = random.Next(100, 150);
                return numberOfCustomers;
            }
            else if (currentDay.todaysWather == "cloudy")
            {
                int numberOfCustomers = random.Next(80, 130);
                return numberOfCustomers;
            }
            else if (currentDay.todaysWather == "rainy")
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
