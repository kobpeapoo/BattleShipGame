using BattleShipBoard.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.UnitOfWorks
{
    public interface IUnitOfWork:IDisposable
    {
        IAttackerRepository attackerRepository { get; }
        IDefenderRepository defenderRepository { get; }
        INewGrameRepository newGrameRepository { get; }

        Task<int> CommitAsync();


    }
}
