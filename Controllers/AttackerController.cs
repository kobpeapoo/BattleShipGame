using BattleShipBoard.Entities;
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
    public class AttackerController : Controller
    {
        private readonly IAttackerService _service;

        public AttackerController(IAttackerService service)
        {
            this._service = service;
        }

        [HttpGet("{newGameId}")]
        public async Task<IActionResult> ShootShip(string newGameId)
        {
            Random rnd = new Random();
            int row = rnd.Next(1, 5);
            int column = rnd.Next(1, 5);

            Attacker attacker = new Attacker();
            attacker.AttackerId = Guid.NewGuid().ToString();
            attacker.NewGameId = newGameId;
            attacker.ShootRow = row;
            attacker.ShootColumn = column;

            var response = await _service.ShootShip(attacker);
            return Ok(response);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
