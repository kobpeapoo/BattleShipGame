using BattleShipBoard.Models;
using BattleShipBoard.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefenderController : Controller
    {
        private readonly IDefenderService _service;
        public DefenderController(IDefenderService service)
        {
            this._service = service;
        }

        [HttpGet]
        public IActionResult Test()
        {
            Random rnd = new Random();
            int row = rnd.Next(1,5);

            return Ok(row);
        }
        [HttpPost]
        public IActionResult AddShip(DefenderModel defender)
        {
            
            return Ok();
        }

    }
}
