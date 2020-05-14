using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SkyAgencyAPI.Models
{
    public partial class Flight_agencyContext : DbContext
    {
        public Flight_agencyContext()
        {
        }

        public Flight_agencyContext(DbContextOptions<Flight_agencyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Flight> Flight { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=PHP128;Database=Flight_agency;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PassWord)
                    .HasColumnName("pass_word")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Purchase).HasColumnName("purchase");

                entity.Property(e => e.ShopCart).HasColumnName("shop_cart");
            });

            modelBuilder.Entity<Flight>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Halt)
                    .HasColumnName("halt")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.StartLocation)
                    .HasColumnName("start_location")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TargetLocation)
                    .HasColumnName("target_location")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
