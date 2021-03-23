using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Homework3.Entities
{
    public class Location
    {
        [Key]
        public int Zipcode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public Location() { }
        public Location(int zipcode, string city, string state, string county)
        {
            Zipcode = zipcode;
            City = city;
            State = state;
            County = county;
        }
    }
}
