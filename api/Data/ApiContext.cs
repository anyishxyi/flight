using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using api.Entities;

namespace api.Data
{
    public class ApiContext : DbContext
    {
        // public IConfiguration Configuration { get; }
        public ApiContext(DbContextOptions<ApiContext> options): base(options)
        {

        }
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer(Configuration.GetConnectionString("MyDbConnection"));
        // }
        public DbSet<Airport> Airport { get; set; }
		public DbSet<Flight> Flight { get; set; }
		public DbSet<Reservation> Reservation { get; set; }
		public DbSet<Seat> Seat { get; set; }
		public DbSet<User> User { get; set; }
    }
}
