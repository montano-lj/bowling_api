﻿namespace domain_project.domain.SeedWork
{

    public interface IRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
