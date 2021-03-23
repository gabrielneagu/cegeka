using Homework3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3.Repositories
{
    public interface ICustomerRepository
    {
        public List<Customer> GetCustomers();
        public void AddCustomer(Customer customer);
    }
}
