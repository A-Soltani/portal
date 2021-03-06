﻿
namespace Portal.Domain.SeedWork
{
    // DDD Patterns comment
    // A pattern related to this practice (placing the repository interfaces in the domain model layer) is the Separated Interface pattern (Interface segregation).
    public interface IRepository<T> where T: IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
