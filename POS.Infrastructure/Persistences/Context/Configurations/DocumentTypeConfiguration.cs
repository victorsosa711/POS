﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructure.Persistences.Context.Configurations
{
    public class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            builder.HasKey(e => e.DocumentTypeId).HasName("PK__Document__DBA390E14D45B33E");

            builder.Property(e => e.Abbreviation)
                .HasMaxLength(5)
                .IsUnicode(false);
            builder.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false);
            builder.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
        }
    }
}
