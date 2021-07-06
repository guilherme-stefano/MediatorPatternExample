using MediatorExample.Data.Interfaces;
using MediatorExample.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorExample.Data.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly Context _context;

        public ClientRepository(Context context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;

        public async Task<IEnumerable<Client>> GetAll()
        {
            return await _context.Clients.AsNoTracking().ToListAsync();
        }

        public void Add(Client client)
        {
            _context.Clients.Add(client);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
