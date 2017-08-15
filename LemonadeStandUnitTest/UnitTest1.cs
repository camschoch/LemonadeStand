using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;
using System.IO;

namespace LemonadeStandUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddOneLemon()
        {
            Store store = new Store();
            Player player = new Player();
            int expectedResult = player.inventory.NumberOfLemon + 1;
            store.AddOneLemon(player);

            int actualResult = player.inventory.NumberOfLemon;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestAddFiveLemon()
        {
            Store store = new Store();
            Player player = new Player();
            int expectedResult = player.inventory.NumberOfLemon + 5;
            store.AddFiveLemon(player);

            int actualResult = player.inventory.NumberOfLemon;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestAddTenLemon()
        {
            Store store = new Store();
            Player player = new Player();
            int expectedResult = player.inventory.NumberOfLemon + 10;
            store.AddTenLemon(player);

            int actualResult = player.inventory.NumberOfLemon;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestAddOneSugar()
        {
            Store store = new Store();
            Player player = new Player();
            int expectedResult = player.inventory.NumberOfSugar + 1;
            store.AddOneSugar(player);

            int actualResult = player.inventory.NumberOfSugar;


            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestAddFiveSugar()
        {
            Store store = new Store();
            Player player = new Player();
            int expectedResult = player.inventory.NumberOfSugar + 5;
            store.AddFiveSugar(player);

            int actualResult = player.inventory.NumberOfSugar;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestAddTenSugar()
        {
            Store store = new Store();
            Player player = new Player();
            int expectedResult = player.inventory.NumberOfSugar + 10;
            store.AddTenSugar(player);

            int actualResult = player.inventory.NumberOfSugar;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
