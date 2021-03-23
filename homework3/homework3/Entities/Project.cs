using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework3.Entities
{
    public class Project
    {
        public int Id { get; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int NoDays { get; set; }
        public Project() { }
        public Project(int customerId, string name, int noDays)
        {
            CustomerId = customerId;
            Name = name;
            NoDays = noDays;
        }
    }
}
