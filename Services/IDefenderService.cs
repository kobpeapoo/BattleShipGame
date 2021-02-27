using BattleShipBoard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.Services
{
    public interface IDefenderService
    {
        Task AddNewShipToBoard(Defender defender);
        bool CheckDefenderPosition(string newGameId,int row,int column);
             
        List<Defender> GetAllShipOnBoard(string newGameId);
    }
}
