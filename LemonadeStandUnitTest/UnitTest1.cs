using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;
using System.IO;

namespace LemonadeStandUnitTest
{
    [TestClass]
    public class TestingMethods
    {
        [TestMethod]
        public void TestAddLemon()
        {
            Store store = new Store();
            Player player = new Player();
            int expectedResult = player.inventory.NumberOfLemon + 1;
            store.AddLemons(player, 1);

            int actualResult = player.inventory.NumberOfLemon;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestAddSugar()
        {
            Store store = new Store();
            Player player = new Player();
            int expectedResult = player.inventory.NumberOfSugar + 1;
            store.AddSugar(player, 1);

            int actualResult = player.inventory.NumberOfSugar;


            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestAddIce()
        {
            Store store = new Store();
            Player player = new Player();
            int expectedResult = player.inventory.NumberOfIce + 10;
            store.AddIce(player, 10);

            int actualResult = player.inventory.NumberOfIce;


            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestSubtractMoney()
        {
            Store store = new Store();
            Player player = new Player();
            double expectedResult = player.playerMoney - .10;
            store.SubtractMoney(player, .10);

            double actualResult = player.playerMoney;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestSetAmountOfIceNeededPerPitcher()
        {
            Player player = new Player();
            int expectedResult = 16;
            player.amountOfIceNeededPerCup = 2;
            player.SetAmountOfIceNeededPerPitcher();

            int actualResult = player.amountOfIceNeededPerPitcher;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestGetTotalAmountSold()
        {
            Player player = new Player();
            Random random = new Random();
            UserInterface UI = new UserInterface();
            Weather CurrentWeather = new Weather();
            Day currentDay = new Day(player, UI, CurrentWeather);
            double expectedResult = 16;
            currentDay.cupsSold = 8;
            player.cupPrice = 2;
            currentDay.GetToalAmountSold(player, random);

            double actualResult = currentDay.totalMoneyForDay;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestSetAmountOfIce()
        {
            Player player = new Player();
            UserInterface UI = new UserInterface();
            double expectedResult = 2;
            string input = "2";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            UI.SetAmmountOfIce(player);
            double actualResult = player.amountOfIceNeededPerCup;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestSetPriceForDay()
        {
            Player player = new Player();
            UserInterface UI = new UserInterface();
            double expectedResult = 2;
            string input = "2";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            UI.SetPriceForDay(player);
            double actualResult = player.cupPrice;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestSubtractNeededSuppliesLemon()
        {
            Player player = new Player();
            player.amountOfLemonNeeded = 4;
            player.inventory.NumberOfLemon = 8;
            int expectedResult = 4;
            player.SubtractingNeededSupplies();

            int actualResult = player.inventory.NumberOfLemon;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestSubtractNeededSuppliesSugar()
        {
            Player player = new Player();
            player.amountOfSugarNeeded = 4;
            player.inventory.NumberOfSugar = 8;
            int expectedResult = 4;
            player.SubtractingNeededSupplies();

            int actualResult = player.inventory.NumberOfSugar;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
