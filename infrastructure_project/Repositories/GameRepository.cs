using domain_project.domain.AggregateModels.Game;
using domain_project.domain.SeedWork;
using Microsoft.EntityFrameworkCore;
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
            _context.Games.Add(entity);

            return Task.FromResult(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var GameToDelete = await _context.Games.FindAsync(id);
            _context.Games.Remove(GameToDelete);
        }

        public IQueryable<Game> GetAsQueryable() => _context.Games.Include(g => g.Frames).AsNoTracking();


        public async Task<Game> GetByIdAsync(int id)
        {
            return await _context.Games.Include(g => g.Frames).FirstOrDefaultAsync(g => g.Id == id);
        }

        public Task<Game> UpdateAsync(Game entity)
        {
            _context.Games.Update(entity);
            return Task.FromResult(entity);
        }
    }
}
