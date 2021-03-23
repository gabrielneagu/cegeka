using Homework3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3.Repositories
{
    public interface IProjectRepository
    {
        public List<Project> GetProjects();
        public void AddProject(Project project);
    }
}
