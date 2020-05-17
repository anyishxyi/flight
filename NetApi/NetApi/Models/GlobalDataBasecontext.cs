using System;
using Microsoft.EntityFrameworkCore;

namespace NetApi.Models
{
    public class GlobalDataBaseContext : DbContext
    {
        public GlobalDataBaseContext(DbContextOptions<GlobalDataBaseContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Airport> Airports { get; set; }
    }
}
