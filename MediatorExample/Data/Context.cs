using MediatorExample.Data.Interfaces;
using MediatorExample.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorExample.Data
{
    public class Context : DbContext, IUnitOfWork
    {
        public Context(DbContextOptions<Context> options) : base (options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Client> Clients { get; set; }

        public async Task<bool> Commit()
        {
            var sucess = await base.SaveChangesAsync() > 0;
            //if (sucesso) await _mediatorHandler.PublicarEventos(this);

            return sucess;
        }
    }
}
