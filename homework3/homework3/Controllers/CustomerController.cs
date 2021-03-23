using Homework3.Repositories;
using Homework3.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerRepository _customerRepository { get; set; }
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet("displayCustomers")]
        public async Task<IActionResult> DisplayCustomers()
        {
            var customers = _customerRepository.GetCustomers();
            return Ok(customers);
        }

        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
            return Ok();
        }
    }
}
