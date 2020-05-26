using System;
namespace api.Models
{
    public class Airport
    {
        public Airport()
        {
        }

        public long id { get; set; }
        public string airportName { get; set; }
        public string airportCountry { get; set; }
        public string airportCity { get; set; }
        public string airportContact { get; set; }
    }
}
