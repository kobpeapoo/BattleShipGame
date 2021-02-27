using BattleShipBoard.Entities;
using BattleShipBoard.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BattleShipContext _context;
        private IAttackerRepository _attackerRepository;
        private IDefenderRepository _defenderRepository;
        private INewGrameRepository _newGrameRepository;

        public UnitOfWork(BattleShipContext context)
        {
            this._context = context;
        }
        public IAttackerRepository attackerRepository => _attackerRepository=_attackerRepository??new AttackerRepository(_context);

        public IDefenderRepository defenderRepository => _defenderRepository = _defenderRepository ?? new DefenderRepository(_context);

        public INewGrameRepository newGrameRepository => _newGrameRepository = _newGrameRepository ?? new NewGameRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
