using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontApp.Models
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
        public int hasEscale { get; set; } = 0;
        public int flightNumber { get; set; }
        public int price { get; set; }
    }
}
