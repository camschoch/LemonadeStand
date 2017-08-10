using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        //Day currentDay = new Day();
        Weather currentWeather;
        public int thirstLvl;
        public Customer(int thirstLvl)
        {
            this.thirstLvl = thirstLvl;
        }
        public void getWeatherThirst()
        {
            
            Random random = new Random();
            string weather = currentWeather.weather;
            if (weather == "sunny")
            {
                
                int randomNumber = random.Next(40, 85);
                int thirstLvlTest = randomNumber;
                thirstLvl = thirstLvlTest;
            }
            else if (weather == "cloudy")
            {
                int randomNumber = random.Next(60, 95);
                int thirstLvlTest = randomNumber;
                thirstLvl = thirstLvlTest;
            }
            else if (weather == "rainy")
            {
                int randomNumber = random.Next(70, 100);
                int thirstLvlTest = randomNumber;
                thirstLvl = thirstLvlTest;
            }
        }
        public void calculateThirst()
        {
            int temp = currentWeather.temp;
            int weatherThirst = thirstLvl;
            if (temp == 65)
            {
                weatherThirst += 10;
                thirstLvl = weatherThirst;
            }
            else if (temp == 75)
            {
                weatherThirst -= 5;
                thirstLvl = weatherThirst;
            }
            else if (temp == 90)
            {
                weatherThirst -= 15;
                thirstLvl = weatherThirst;
            }
            else
            {
                weatherThirst += 0;
                thirstLvl = weatherThirst;
            }
        }
        public void willOrNotBuy()
        {
            Random random = new Random();
            List<int> oneHundred = new List<int>();
            for(int i = 1; i < 100; i++)
            {
                oneHundred.Add(i);
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
