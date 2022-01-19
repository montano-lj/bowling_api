using domain_project.domain.AggregateModels.Game;
using domain_project.domain.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace infrastructure_project
{
    public class ApplicationDbContext : DbContext, IUnitOfWork
    {

        public DbSet<Game> Games { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
