using Homework3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3.Repositories
{
    public interface IFreelancerRepository
    {
        public List<Freelancer> GetFreelancers();
        public void AddFreelancer(Freelancer freelancer);
    }
}
