using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace api.Models
{
	public class AppContext: DbContext
	{
		public DbSet<Airport> Airport { get; set; }
		public DbSet<Flight> Flight { get; set; }
		public DbSet<Reservation> Reservation { get; set; }
		public DbSet<Seat> Seat { get; set; }
		public DbSet<User> User { get; set; }
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Airport>().ToTable("Airport");
			modelBuilder.Entity<Flight>().ToTable("Flight");
			modelBuilder.Entity<Reservation>().ToTable("Reservation");
			modelBuilder.Entity<Seat>().ToTable("Seat");
			modelBuilder.Entity<User>().ToTable("User");
		}
	}
}