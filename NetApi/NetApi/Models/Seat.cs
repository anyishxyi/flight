using System;
namespace NetApi.Models
{
    public class Seat
    {
        public enum SeatCategory { ECONOMIC, COMMERCIAL, FIRST_CLASS };

        public Seat()
        {
        }
        public long id { get; set; }
        public int placeNumber { get; set; }
        public bool isEmpty { get; set; }
        public User user { get; set; }
        public Flight flight { get; set; }
        public SeatCategory seatCategory { get; set; }
}
}
