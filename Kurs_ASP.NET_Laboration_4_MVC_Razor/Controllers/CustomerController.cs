using Kurs_ASP.NET_Laboration_4_MVC_Razor.Models;
using Kurs_ASP.NET_Laboration_4_MVC_Razor.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs_ASP.NET_Laboration_4_MVC_Razor.Controllers
{
    public class CustomerController : Controller
    {
        private ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IActionResult List()
        {
            var listOfCustomers = new CustomerListViewModel();
            listOfCustomers.Customers = _customerRepository.GetAllCustomers;
            return View(listOfCustomers);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            var singleCustomer = _customerRepository.GetCustomer(id);
            if (singleCustomer == null)
            {
                return NotFound();
            }
            return View(singleCustomer);
        }

        public IActionResult Form()
        {
            return View();
        }


        [HttpPost]
        [Route("Customer/Add")]
        public async Task<ActionResult<Customer>> AddCustomer(Customer customer)
        {
            try
            {
                if (customer == null)
                {
                    return BadRequest();
                }
                var newCustomer = await _customerRepository.AddCustomer(customer);

                Details(newCustomer.CustomerId);
                return newCustomer;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error, failed to Create a new object to Database...");
            }
        }

        [Route("Customer/Test")]
        public string Test(Customer customer)
        {
            return $"Förnamn: {customer.FirstName}, Efternamn: {customer.LastName}, Email: {customer.Email}";
        }
    }
}
