using System;
namespace NetApi.Models
{
    public class Reservation
    {
        public Reservation()
        {
        }
        public int id { get; set; }
        public virtual Flight flight { get; set; }
        public virtual User user { get; set; }
    }
}
