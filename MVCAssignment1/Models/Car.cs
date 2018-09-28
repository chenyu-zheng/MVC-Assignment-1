using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignment1.Models
{
    public class Car
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }
}