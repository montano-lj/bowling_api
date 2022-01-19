using domain_project.domain.AggregateModels.Game;
using domain_project.domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure_project.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly ApplicationDbContext _context;
        public IUnitOfWork UnitOfWork => _context;

        public GameRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Game> CreateAsync(Game entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Game> GetAsQueryable()
        {
            throw new NotImplementedException();
        }

        public Task<Game> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Game> UpdateAsync(Game entity)
        {
            throw new NotImplementedException();
        }
    }
}
