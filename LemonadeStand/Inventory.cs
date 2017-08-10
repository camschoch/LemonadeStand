using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public int NumberOfLemon;
        public int NumberOfIce;
        public int NumberOfSugar;
        Lemon lemons = new Lemon();
        Ice ice = new Ice();
        Sugar sugar = new Sugar();
    }
}
