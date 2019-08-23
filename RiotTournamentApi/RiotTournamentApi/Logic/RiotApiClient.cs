using Newtonsoft.Json;
using RiotTournamentApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace RiotTournamentApi.Logic
{
    public class RiotApiClient
    {
        static HttpClient client = new HttpClient();

        public RiotApiClient()
        {
            if (client.BaseAddress == null)
            {
                client.BaseAddress = new Uri("https://eun1.api.riotgames.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("X-Riot-Token", "RGAPI-cd6ad702-0f66-41ad-9d83-fbc3b6eae9a9");
            }
        }

        public async Task<SummonerRankDTO> GetSummonerByName (string summonerName)
        {
            var getSummonerByNameEndpoint = $"/lol/summoner/v4/summoners/by-name/{summonerName}";
            var getSummonerByNameResponse = await client.GetAsync(getSummonerByNameEndpoint);
            var summonerRaw = await getSummonerByNameResponse.Content.ReadAsStringAsync();
            if (getSummonerByNameResponse.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception("Riot api call failed!" + Environment.NewLine + summonerRaw);
            }
            var summoner = JsonConvert.DeserializeObject<SummonerDTO>(summonerRaw);

            var endpoint = $"/lol/league/v4/entries/by-summoner/{summoner.Id}";
            var summonerRanks =  await client.GetAsync(endpoint);

            var summonerRanksRaw = await summonerRanks.Content.ReadAsStringAsync();
            if (summonerRanks.StatusCode != System.Net.HttpStatusCode.OK)
            {
                throw new Exception("Riot api call failed!" + Environment.NewLine + summonerRanksRaw);
            }
            var result = JsonConvert.DeserializeObject<List<LeagueEntryDTO>>(summonerRanksRaw);

            return new SummonerRankDTO() { Id = "None if your business", SearchString = summonerName, LeagueEntries = result };
        }
    }
}
