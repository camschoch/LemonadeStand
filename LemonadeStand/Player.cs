using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string recipe;
        public int pitchers = 0;
        public double playerMoney = 20;
        public int amountOfLemonNeeded;
        public int amountOfSugarNeeded;
        public int amountOfIceNeededPerCup;
        public int amountOfIceNeededPerPitcher;
        Inventory inventory = new Inventory();
        Store store = new Store();
        UserInterface UI;

        public void PlayerName()
        {
            
        }
        public void SetAmountOfIceNeededPerPitcher()
        {
            if (amountOfIceNeededPerCup == 2)
            {
                amountOfIceNeededPerPitcher = 16;
            }
            else if (amountOfIceNeededPerCup == 4)
            {
                amountOfIceNeededPerPitcher = 31;
            }
            else if (amountOfIceNeededPerCup == 8)
            {
                amountOfIceNeededPerPitcher = 64;
            }
        }
        public void SwitchCallNumberOfPitchers()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    if (inventory.NumberOfLemon < amountOfLemonNeeded || inventory.NumberOfSugar < amountOfSugarNeeded || inventory.NumberOfIce < amountOfIceNeededPerPitcher)
                    {
                        Console.WriteLine("Sorry you are lacking one or more of the items required to make this.");
                        Console.ReadLine();
                        //RETURN TO MAIN MENU//
                    }
                    else
                    {
                        pitchers++;
                    }
                    break;
                case "2":
                    if (inventory.NumberOfLemon < amountOfLemonNeeded * 2 || inventory.NumberOfSugar < amountOfSugarNeeded * 2 || inventory.NumberOfIce < amountOfIceNeededPerPitcher * 2)
                    {
                        Console.WriteLine("Sorry you are lacking one or more of the items required to make this many please choose a lower amount.");
                        Console.ReadLine();
                        UI.SetNumberOfPitchers();
                    }
                    else
                    {
                        pitchers += 2;
                    }
                    break;
                case "3":
                    if (inventory.NumberOfLemon < amountOfLemonNeeded * 3 || inventory.NumberOfSugar < amountOfSugarNeeded * 3 || inventory.NumberOfIce < amountOfIceNeededPerPitcher * 3)
                    {
                        Console.WriteLine("Sorry you are lacking one or more of the items required to make this many please choose a lower amount.");
                        Console.ReadLine();
                        UI.SetNumberOfPitchers();
                    }
                    else
                    {
                        pitchers += 3;
                    }
                    break;
                case "4":
                    if (inventory.NumberOfLemon < amountOfLemonNeeded * 4 || inventory.NumberOfSugar < amountOfSugarNeeded * 4 || inventory.NumberOfIce < amountOfIceNeededPerPitcher * 4)
                    {
                        Console.WriteLine("Sorry you are lacking one or more of the items required to make this many please choose a lower amount.");
                        Console.ReadLine();
                        UI.SetNumberOfPitchers();
                    }
                    else
                    {
                        pitchers += 4;
                    }
                    break;
                case "5":
                    if (inventory.NumberOfLemon < amountOfLemonNeeded * 5 || inventory.NumberOfSugar < amountOfSugarNeeded * 5 || inventory.NumberOfIce < amountOfIceNeededPerPitcher * 5)
                    {
                        Console.WriteLine("Sorry you are lacking one or more of the items required to make this many please choose a lower amount.");
                        Console.ReadLine();
                        UI.SetNumberOfPitchers();
                    }
                    else
                    {
                        pitchers += 5;
                    }
                    break;
                case "6":
                    if (inventory.NumberOfLemon < amountOfLemonNeeded * 6 || inventory.NumberOfSugar < amountOfSugarNeeded * 6 || inventory.NumberOfIce < amountOfIceNeededPerPitcher * 6)
                    {
                        Console.WriteLine("Sorry you are lacking one or more of the items required to make this many please choose a lower amount.");
                        Console.ReadLine();
                        UI.SetNumberOfPitchers();
                    }
                    else
                    {
                        pitchers += 6;
                    }
                    break;
                case "7":
                    if (inventory.NumberOfLemon < amountOfLemonNeeded * 7 || inventory.NumberOfSugar < amountOfSugarNeeded * 7 || inventory.NumberOfIce < amountOfIceNeededPerPitcher * 7)
                    {
                        Console.WriteLine("Sorry you are lacking one or more of the items required to make this many please choose a lower amount.");
                        Console.ReadLine();
                        UI.SetNumberOfPitchers();
                    }
                    else
                    {
                        pitchers += 7;
                    }
                    break;
                default:
                    Console.WriteLine("Sorry that wasn't an option please try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
