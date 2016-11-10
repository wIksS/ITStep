using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCasino.Models
{
    public class Game
    {
        public Game(string provider, string providerGameUrl, string gameUrl)
        {
            this.Id = Guid.NewGuid();
            this.Provider = provider;
            this.ProviderGameUrl = providerGameUrl;
            this.GameUrl = gameUrl;
        }

        public Guid Id { get; set; }

        public GameInfo GameInfo{ get; set; }

        public string Provider { get; set; }

        public string ProviderGameUrl { get; set; }

        public string GameUrl { get; set; }
    }
}
