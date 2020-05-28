using System;
namespace api.Entities
{
    public class Flight
    {
        public Flight(){}
        public long id { get; set; }
        public DateTime departureDate { get; set; }
        public DateTime arrivalDate { get; set; }
        public string departureAirport { get; set; }
        public string arrivalAirport { get; set; }
        public int numberOfSeat { get; set; }
        public bool hasEscale { get; set; }
        public int flightNumber { get; set; }
    }
}
