using domain_project.domain.SeedWork;

namespace domain_project.domain.AggregateModels.Game
{
    public interface IGameRepository : IRead<Game>, IWrite<Game>, IRepository<Game>
    {

    }
}
