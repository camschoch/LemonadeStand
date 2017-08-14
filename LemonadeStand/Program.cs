using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame(game);

            //Customer test = new Customer(0);
            //double teatOne = test.RandomNumberBetween(.25, 1.50);
        }

    }
}
