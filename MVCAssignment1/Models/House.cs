using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignment1.Models
{
    public class House
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public double LotSize { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}