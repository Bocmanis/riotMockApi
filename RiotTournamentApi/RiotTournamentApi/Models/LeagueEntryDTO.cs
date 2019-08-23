using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiotTournamentApi.Models
{
    public class LeagueEntryDTO
    {
        public QueueType QueueType { get;set; }
        public string SummonerName { get; set; }
        public bool HotStreak { get; set; }
        public long Wins { get; set; }
        public long Losses { get; set; }
        public Tier Tier { get; set; }
        public string LeagueId { get; set; }
        public bool Inactive { get; set; }
        public bool FreshBlood { get; set; }
        public string Rank { get; set; }
        public string SummonerId { get; set; }
        public string LeaguePoints { get; set; }
        public MiniSeriesDTO MiniSeries { get; set; }
    }
}
