using BattleShipBoard.Entities;
using BattleShipBoard.Models;
using BattleShipBoard.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewGameController : ControllerBase
    {
        private readonly INewGameService _service;
        public NewGameController(INewGameService service)
        {
            this._service = service;
        }
       
        //public string Get()
        //{
        //    return "OK";
        //}

        //Create New game
        [HttpGet]
        public async Task<IActionResult> NewGame()
        {
            try
            {
                string newGameId = await _service.CreateNewGame();
                NewGameModel model = new NewGameModel();
                model.code = "200";
                model.description = "Create New Game Success";
                model.NewGameId = newGameId;
                return Ok(JsonConvert.SerializeObject(model));
            }
            catch (Exception)
            {

                throw;
            }
            

        }
        [HttpGet("GameStatus/{newGameId}")]
        public async Task<IActionResult> NewGameStatus(string newGameId)
        {
            try
            {
                var status = await _service.CheckNewGameStatus(newGameId);
                NewGameModel model = new NewGameModel();
                model.code = "200";
                model.description = "Game Status";
                model.NewGameId = newGameId;
                model.AttackerWinStatus = status.AttackerWinStatus;
                model.DefenderStatus = status.DefenderStatus;
                model.StartGameDatetime = status.StartGameDatetime;
                model.EndGameDatetime = status.EndGameDatetime;
                return Ok(JsonConvert.SerializeObject(model));
            }
            catch (Exception)
            {

                throw;
            }
        }
        //public IActionResult Index()
        //{
        //    return Ok("");
        //}
    }
}
