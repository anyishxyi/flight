using System;

namespace web.Models
{
	public class FlightModel
	{
		public int FlightId { get; set; }
		public string currency { get; set; }
		public DateTime departure { get; set; }
		public DateTime arrival { get; set; } 
		public float price { get; set; }
		public string time { get; set; }
	}
}