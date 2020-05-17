using System;
namespace NetApi.Models
{
    public class Reservation
    {
        public Reservation()
        {
        }
        public long id { get; set; }
        public Flight flight { get; set; }
        public User user { get; set; }
    }
}
