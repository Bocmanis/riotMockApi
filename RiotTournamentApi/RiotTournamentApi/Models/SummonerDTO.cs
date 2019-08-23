using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiotTournamentApi.Models
{
    public class SummonerDTO
    {
        public long ProfileIconId { get; set; }
        public string Name { get; set; }
        public string Puuid { get; set; }
        public long SummonerLevel { get; set; }
        public long RevisionDate { get; set; }
        public string Id { get; set; }
        public string AccountId { get; set; }
    }
}
