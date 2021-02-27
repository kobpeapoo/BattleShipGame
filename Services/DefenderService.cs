using BattleShipBoard.Entities;
using BattleShipBoard.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.Services
{
    public class DefenderService : IDefenderService
    {
        private readonly IUnitOfWork _context;
        public DefenderService(IUnitOfWork context)
        {
            this._context = context;
        }
        public Task AddNewShipToBoard(Defender defender)
        {
            



            throw new NotImplementedException();
        }

        public bool CheckDefenderPosition(string newGameId, int row, int column)
        {
            throw new NotImplementedException();
        }

        public List<Defender> GetAllShipOnBoard(string newGameId)
        {
            throw new NotImplementedException();
        }
    }
}
