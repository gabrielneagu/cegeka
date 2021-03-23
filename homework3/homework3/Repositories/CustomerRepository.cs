using Homework3.Data;
using Homework3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework3.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly WorkLoadDbContext _context;
        public CustomerRepository(WorkLoadDbContext context)
        {
            _context = context;
        }
        public void AddCustomer(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
        }

        public List<Customer> GetCustomers()
        {
            return _context.Customer.ToList();
        }
    }
}
