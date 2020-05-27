using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontApp.Models
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
