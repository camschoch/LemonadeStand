using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Day currentDay;
        Player player = new Player();
        UserInterface UI;
        Weather weather;
        public void StartGame()
        {
            weather.GetWeatherForcast();
            UI.MainMenu();
        }
        public void StartPlayerSetup()
        {
            UI.CallAllChoosingLemonade();
        }
        public void StartDay()
        {
            currentDay.CallAllMethodsDay();
        }
    }
}
