using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework3.Entities
{
    public class Customer
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Zipcode { get; set; }
        public Customer() { }
        public Customer(string name, string address, int zipcode)
        {
            Name = name;
            Address = address;
            Zipcode = zipcode;
        }
    }
}
