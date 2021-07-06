using MediatorExample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorExample.Data.Interfaces
{
    public interface IClientRepository : IRepository<Client>
    {
        void Add(Client client);

        Task<IEnumerable<Client>> GetAll();
    }
}
