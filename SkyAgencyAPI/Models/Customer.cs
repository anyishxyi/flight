using System;
using System.Collections.Generic;

namespace SkyAgencyAPI.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
        public int? ShopCart { get; set; }
        public int? Purchase { get; set; }
    }
}
