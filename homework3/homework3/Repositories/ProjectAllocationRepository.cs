using Homework3.Data;
using Homework3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework3.Repositories
{
    public class ProjectAllocationRepository : IProjectAllocationRepository
    {
        private readonly WorkLoadDbContext _context;
        public ProjectAllocationRepository(WorkLoadDbContext context)
        {
            _context = context;
        }
        public void AddProjectAllocation(ProjectAllocation projectAllocation)
        {
            _context.ProjectAllocation.Add(projectAllocation);
            _context.SaveChanges();
        }

        public List<ProjectAllocation> GetProjectAllocations()
        {
            return _context.ProjectAllocation.ToList();
        }
    }
}
