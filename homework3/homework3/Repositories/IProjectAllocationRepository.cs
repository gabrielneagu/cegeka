using Homework3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3.Repositories
{
    public interface IProjectAllocationRepository
    {
        public List<ProjectAllocation> GetProjectAllocations();
        public void AddProjectAllocation(ProjectAllocation projectAllocation);
    }
}
