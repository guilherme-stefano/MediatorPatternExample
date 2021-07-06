using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorExample.Data.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
