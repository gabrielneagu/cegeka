using Homework3.Data;
using Homework3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework3.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly WorkLoadDbContext _context;
        public ProjectRepository(WorkLoadDbContext context)
        {
            _context = context;
        }
        public void AddProject(Project project)
        {
            _context.Project.Add(project);
            _context.SaveChanges();
        }

        public List<Project> GetProjects()
        {
            return _context.Project.ToList();
        }
    }
}
