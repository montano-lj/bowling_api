using domain_project.domain.SeedWork;

namespace domain_project.domain.AggregateModels.Game
{
    public class Game : BaseEntity, IAggregateRoot
    {
        public object Frames { get; set; }
    }
}