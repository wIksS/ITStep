using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GameCasino.Models;

namespace JSONSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("blizzard", "blizzardonlinecasiono.com", "/onlinecasino.com");
            GameInfo info = new GameInfo();
            info.ConnectPlayer("viktor");
            game.GameInfo = info;

            string json = JsonConvert.SerializeObject(game, Formatting.Indented);
            Console.WriteLine(json);

            var newGame = JsonConvert.DeserializeObject<Game>(json);

            Console.WriteLine("Is deep copy --> " + !(newGame.GameInfo == game.GameInfo));

            Console.WriteLine(newGame.GameInfo.PlayersPlaying);
        }
    }
}
