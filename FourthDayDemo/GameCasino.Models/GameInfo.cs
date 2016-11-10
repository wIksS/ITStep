using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCasino.Models
{

    public class GameInfo
    {
        private int playersPlaying;

        public GameInfo()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public int PlayersPlaying
        {
            get { return this.playersPlaying; }
            set { this.playersPlaying = value; }
        }

        public bool ConnectPlayer(string playerName)
        {
            // TODO: connect player to game provider server
            PlayersPlaying++;

            return true;
        }
    }
}
