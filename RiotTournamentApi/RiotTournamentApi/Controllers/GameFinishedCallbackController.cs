﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RiotTournamentApi.Models;

namespace RiotTournamentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameFinishedCallbackController : ControllerBase
    {
        [HttpPost]
        public void PostGameResults([FromBody]GameFinishedCallback gameFinishedCallbackContent)
        {

        }
    }
}