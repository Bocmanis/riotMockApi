using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RiotTournamentApi.Models
{
    public class SummonerRankDTO
    {
        public string Id { get; set; }
        public List<LeagueEntryDTO> LeagueEntries { get; set; }
        public string SearchString { get; set; }
    }
}
