﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using TunNetCom.SilkRoadErp.Sales.Domain.Entites;

#nullable disable

namespace TunNetCom.SilkRoadErp.Sales.Domain.Entites.Configurations
{
    public partial class AvoirsConfiguration : IEntityTypeConfiguration<Avoirs>
    {
        public void Configure(EntityTypeBuilder<Avoirs> entity)
        {
            entity.HasKey(e => e.Num).HasName("PK_dbo.Avoirs");

            entity.Property(e => e.ClientId).HasColumnName("clientId");
            entity.Property(e => e.Date)
            .HasColumnType("datetime")
            .HasColumnName("date");

            entity.HasOne(d => d.Client).WithMany(p => p.Avoirs)
            .HasForeignKey(d => d.ClientId)
            .HasConstraintName("FK_dbo.Avoirs_dbo.Client_clientId");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<Avoirs> entity);
    }
}
