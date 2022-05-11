using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs_ASP.NET_Laboration_4_MVC_Razor.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Labb4DbContext _labb4DbContext;

        public CustomerRepository(Labb4DbContext labbContext)
        {
            _labb4DbContext = labbContext;
        }
        public IEnumerable<Customer> GetAllCustomers {
            get
            {
                return _labb4DbContext.Customers.OrderBy(l => l.LastName).ThenBy(f => f.FirstName);
            } 
        }
        

        public async Task<Customer> AddCustomer(Customer newCustomer)
        {
            var customer = await _labb4DbContext.Customers.AddAsync(newCustomer);
            await _labb4DbContext.SaveChangesAsync();
            return customer.Entity;
        }

        public void DeleteCustomer(Customer customerToDelete)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BorrowedBook> GetBooks(int id)
        {
            return _labb4DbContext.BorrowedBooks.Where(c => c.CustomerId == id);
        }

        public Customer GetCustomer(int id)
        {
            return _labb4DbContext.Customers.Include(b => b.BorrowedBooks).FirstOrDefault(i => i.CustomerId == id);
        }

        public Task<Customer> UpdateCustomer(Customer customerToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
