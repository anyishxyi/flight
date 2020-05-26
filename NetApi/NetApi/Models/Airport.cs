using System;
namespace NetApi.Models
{
    public class Airport
    {
        public Airport()
        {
        }

        public int id { get; set; }
        public string airportName { get; set; }
        public string airportCountry { get; set; }
        public string airportCity { get; set; }
        public string airportContact { get; set; }
    }
}
