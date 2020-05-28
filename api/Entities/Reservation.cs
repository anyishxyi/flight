using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace api.Entities
{
    public class Reservation
    {
        public Reservation(){}
        public long id { get; set; }
        public long? FlightID { get; set; }
        [ForeignKey("FlightID")]
        public virtual Flight flight { get; set; }
        public long? UserID { get; set; }
        [ForeignKey("FlightID")]
        public virtual User user { get; set; }
    }
}
