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
        public Customer()
        {
        }
        
        public void buyOrNo()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            List<string> willBuy = new List<string>() { "yes", "no" };
            string yesOrNo = willBuy [randomNumber];
            if (yesOrNo == "yes")
            {
                cupsSold++;
            }
        }
    }
}
