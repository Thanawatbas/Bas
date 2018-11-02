using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace pp.Models
{
    public partial class BasContext : DbContext
    {
        public BasContext()
        {
        }

        public BasContext(DbContextOptions<BasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cat> Cats { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustType> CustTypes { get; set; }
        public virtual DbSet<Initial> Initials { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cat>(entity =>
            {
                entity.Property(e => e.CatId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Catname).IsUnicode(false);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustId)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.InitialCode).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<CustType>(entity =>
            {
                entity.Property(e => e.CustType1).ValueGeneratedNever();

                entity.Property(e => e.NameType).IsUnicode(false);
            });

            modelBuilder.Entity<Initial>(entity =>
            {
                entity.Property(e => e.InitialCode)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.InitialName).IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CatId).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.UnitCode).IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Status1).ValueGeneratedNever();

                entity.Property(e => e.StatusName).IsUnicode(false);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.Property(e => e.UnitCode)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Unitname).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
