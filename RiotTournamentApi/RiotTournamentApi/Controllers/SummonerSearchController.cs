using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RiotTournamentApi.Logic;
using RiotTournamentApi.Models;

namespace RiotTournamentApi.Controllers
{
    public class SummonerSearchController : Controller
    {
        public IActionResult Index()
        {
            var model = new SummonerRankDTO();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Search(string searchString)
        {
            var model = await new RiotApiClient().GetSummonerByName(searchString);
            return View("Index", model);
        }
    }
}