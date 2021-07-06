using MediatorExample.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatorExample.Data.Mapping
{
    public class ClientMapping : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.SecondName)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.Email)
            .IsRequired()
            .HasColumnType("varchar(200)");

            builder.ToTable("Clientss");
        }
    }
}
