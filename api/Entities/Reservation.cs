using System;
namespace api.Entities
{
    public class Reservation
    {
        public Reservation(){}
        public long id { get; set; }
        public virtual Flight flight { get; set; }
        public virtual User user { get; set; }
    }
}
