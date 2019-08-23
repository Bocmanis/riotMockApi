using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiotTournamentApi.Models
{
    public class GameFinishedCallback
    {
        public long StartTime { get; set; }
        public List<Player> WinningTeam { get; set; }
        public List<Player> LosingTeam { get; set; }

        //region + guid
        public string ShortCode { get; set; }
        //customizable, probably can be provided when creating a game
        public string MetaData { get; set; }
        public long GameId { get; set; }
        //seems like a guid
        public string GameName { get; set; }
        //might be enum
        public string GameType { get; set; }
        //numeric, might be enum as well
        public int GameMap { get; set; }
        public string GameMode { get; set; }
        public string Region { get; set; }
    }
}
