using Microsoft.EntityFrameworkCore;
using api.Entities;

namespace api.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext ()
        {
        }
        public DbSet<Airport> Airport { get; set; }
		public DbSet<Flight> Flight { get; set; }
		public DbSet<Reservation> Reservation { get; set; }
		public DbSet<Seat> Seat { get; set; }
		public DbSet<User> User { get; set; }
    }
}
