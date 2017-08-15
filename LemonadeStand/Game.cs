using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Day currentDay;
        UserInterface UI = new UserInterface();
        public Player player = new Player();
        public Weather CurrentWeather;
        //public Day currenDay;
        
        public void StartGame(Game game)
        {
            
            CurrentWeather = new Weather();
            CurrentWeather.GetWeatherForcast();
            UI.MainMenu(player, game, currentDay, CurrentWeather, UI);
        }
        public void InUI()
        {
             UI = new UserInterface();
        }
        public void StartPlayerSetup(Player player, Game game, Day currentDay, Weather CurrentWeather, UserInterface UI)
        {
            UI.CallAllChoosingLemonade(player, game, currentDay, CurrentWeather, UI);
        }
        public void StartDay(Game game)
        {
            currentDay = new Day(player, UI, CurrentWeather);
            CurrentWeather.ActualWeather();
            currentDay.CallAllMethodsDay(player, game, currentDay, CurrentWeather);
        }
    }
}
