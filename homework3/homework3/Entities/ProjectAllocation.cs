using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework3.Entities
{
    public class ProjectAllocation
    {
        public int Id { get; }
        public int FreelancerId { get; set; }
        public int ProjectId { get; set; }
        public DateTime WorkDay { get; set; }
        public decimal PricePerHour { get; set; }
        public int NoHours { get; set; }
        public ProjectAllocation() { WorkDay = DateTime.Now; }
        public ProjectAllocation(int freelancerId, int projectId, 
            DateTime workDay, decimal pricePerHour, int noHours)
        {
            FreelancerId = freelancerId;
            ProjectId = projectId;
            WorkDay = workDay;
            PricePerHour = pricePerHour;
            NoHours = noHours;
        }

    }
}
