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

        public DbSet<User> User { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Seat> Seat { get; set; }
        public DbSet<Airport> Airport { get; set; }
    }
}
