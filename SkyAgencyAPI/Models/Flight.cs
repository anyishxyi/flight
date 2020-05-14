using System;
using System.Collections.Generic;

namespace SkyAgencyAPI.Models
{
    public partial class Flight
    {
        public int Id { get; set; }
        public string StartLocation { get; set; }
        public string TargetLocation { get; set; }
        public string Halt { get; set; }
        public int? Amount { get; set; }
        public int? Price { get; set; }
    }
}
