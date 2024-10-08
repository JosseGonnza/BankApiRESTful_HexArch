﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(p => p.LastName)
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(p => p.DateOfBirth)
                .IsRequired();

            builder.Property(p => p.PhoneNumber)
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(p => p.Email)
                .HasMaxLength(100);

            builder.Property(p => p.Address)
                .HasMaxLength(120)
                .IsRequired();

            builder.Property(p => p.Age);

            builder.Property(p => p.CreatedBy)
                .HasMaxLength(30);

            builder.Property(p => p.LastModifiedBy)
                .HasMaxLength(30);
        }
    }
}
