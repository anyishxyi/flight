using System;
namespace api.Models
{
    public class Airport
    {
        public Airport(){}
        public long id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
    }
}
