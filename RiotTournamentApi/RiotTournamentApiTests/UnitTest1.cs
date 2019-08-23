using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using RiotTournamentApi.Models;
using System.Collections.Generic;

namespace RiotTournamentApiTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var textToDeserialize = @"[{""leagueId"":""3ee8a050-1fe7-11e9-bb8b-06a5f0ea0e4b"",""queueType"":""RANKED_SOLO_5x5"",""tier"":""DIAMOND"",""rank"":""IV"",""summonerId"":""zHhX51xwJSCtUiJ3dK2tns0vijS8Tb6UQmJR074v-H5ssNo"",""summonerName"":""Bocmanis"",""leaguePoints"":78,""wins"":63,""losses"":52,""veteran"":false,""inactive"":false,""freshBlood"":false,""hotStreak"":false},{""leagueId"":""d0575ee0-25a1-11e9-8b50-0649c773fbaf"",""queueType"":""RANKED_FLEX_SR"",""tier"":""DIAMOND"",""rank"":""IV"",""summonerId"":""zHhX51xwJSCtUiJ3dK2tns0vijS8Tb6UQmJR074v-H5ssNo"",""summonerName"":""Bocmanis"",""leaguePoints"":31,""wins"":8,""losses"":7,""veteran"":false,""inactive"":false,""freshBlood"":false,""hotStreak"":false},{""leagueId"":""9965cc20-ad5d-11e9-8c97-0649c773fbaf"",""queueType"":""RANKED_TFT"",""tier"":""DIAMOND"",""rank"":""III"",""summonerId"":""zHhX51xwJSCtUiJ3dK2tns0vijS8Tb6UQmJR074v-H5ssNo"",""summonerName"":""Bocmanis"",""leaguePoints"":0,""wins"":65,""losses"":185,""veteran"":false,""inactive"":false,""freshBlood"":false,""hotStreak"":false}]";
            var result = JsonConvert.DeserializeObject<List<LeagueEntryDTO>>(textToDeserialize);

        }
    }
}
