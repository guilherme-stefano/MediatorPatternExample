using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExample.Data.Interfaces
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
