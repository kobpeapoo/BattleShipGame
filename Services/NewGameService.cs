using BattleShipBoard.Entities;
using BattleShipBoard.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.Services
{
    public class NewGameService : INewGameService
    {
        private readonly IUnitOfWork _context;
        public NewGameService(IUnitOfWork context)
        {
            this._context = context;
        }
        public async Task<NewGame> CheckNewGameStatus(string newGameId)
        {
            return await _context.newGrameRepository.NewGameStatus(newGameId);
        }

        public async Task<string> CreateNewGame()
        {
            NewGame newGame = new NewGame
            {
                NewGameId= Guid.NewGuid().ToString(),
                StartGameDatetime=DateTime.Now
            };
            await _context.newGrameRepository.NewGame(newGame);

            return newGame.NewGameId;
        }
    }
}
