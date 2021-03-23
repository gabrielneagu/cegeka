using Homework3.Data;
using Homework3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework3.Repositories
{
    class FreelancerRepository : IFreelancerRepository
    {
        private readonly WorkLoadDbContext _context;
        public FreelancerRepository(WorkLoadDbContext context)
        {
            _context = context;
        }
        public void AddFreelancer(Freelancer freelancer)
        {
            _context.Freelancer.Add(freelancer);
            _context.SaveChanges();
        }

        public List<Freelancer> GetFreelancers()
        {
            return _context.Freelancer.ToList();
        }
    }
}
