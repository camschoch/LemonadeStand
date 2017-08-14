using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        UserInterface UI;
        Inventory inventory;
        Player player;
        public void BuyLemons()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    inventory.NumberOfLemon++;
                    player.playerMoney -= .10;
                    break;
                case "5":
                    inventory.NumberOfLemon += 5;
                    player.playerMoney -= .50;
                    break;
                case "10":
                    inventory.NumberOfLemon += 10;
                    player.playerMoney -= 1;
                    break;
                case "leave":
                    break;
                default:
                    Console.WriteLine("Sorry that wasn't an option please try again.");
                    Console.ReadLine();
                    BuyLemons();
                    break;
            }

        }
        public void BuySugar()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    inventory.NumberOfSugar++;
                    player.playerMoney -= .10;
                    break;
                case "5":
                    inventory.NumberOfSugar += 5;
                    player.playerMoney -= .50;
                    break;
                case "10":
                    inventory.NumberOfSugar += 10;
                    player.playerMoney -= 1;
                    break;
                case "leave":
                    break;
                default:
                    Console.WriteLine("Sorry that wasn't an option please try again.");
                    Console.ReadLine();
                    BuySugar();
                    break;
            }

        }
        public void BuyIce()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "10":
                    inventory.NumberOfIce += 10;
                    player.playerMoney -= .10;
                    break;
                case "50":
                    inventory.NumberOfIce += 50;
                    player.playerMoney -= .50;
                    break;
                case "100":
                    inventory.NumberOfIce += 100;
                    player.playerMoney -= 1;
                    break;
                case "leave":
                    break;
                default:
                    Console.WriteLine("Sorry that wasn't an option please try again.");
                    Console.ReadLine();
                    BuyIce();
                    break;
            }
        }
    }
}
