using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontApp.Models
{
    public class Seat
    {
        public enum SeatCategory { ECONOMIC, COMMERCIAL, FIRST_CLASS };

        public Seat()
        {
        }
        public int id { get; set; }
        public int placeNumber { get; set; }
        public bool isEmpty { get; set; }
        public virtual User user { get; set; }
        public virtual Flight flight { get; set; }
        public string seatCategory { get; set; } = SeatCategory.ECONOMIC.ToString();
    }
}
