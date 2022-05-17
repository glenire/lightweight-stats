﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LightweightStats.Data.Models
{
    public partial class DevelopmentLightweightStatsContext : DbContext
    {
        public DevelopmentLightweightStatsContext()
        {
        }

        public DevelopmentLightweightStatsContext(DbContextOptions<DevelopmentLightweightStatsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Club> Clubs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Development.LightweightStats;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>(entity =>
            {
                entity.ToTable("Club");

                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}