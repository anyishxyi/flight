using System;
namespace NetApi.Models
{
    public class Flight
    {
        public Flight()
        {
        }

        public int id { get; set; }
        public string departureDate { get; set; }
        public string arrivalDate { get; set; }
        public string departureAirport { get; set; }
        public string arrivalAirport { get; set; }
        public int numberOfSeat { get; set; }
        public bool hasEscale { get; set; }
        public int flightNumber { get; set; }
        public float price { get; set; }
}
}
