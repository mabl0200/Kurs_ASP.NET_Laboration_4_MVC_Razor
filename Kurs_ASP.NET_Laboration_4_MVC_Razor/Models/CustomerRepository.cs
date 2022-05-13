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
                return _labb4DbContext.Customers
                    .OrderBy(l => l.LastName)
                    .ThenBy(f => f.FirstName)
                    .Include(b => b.BorrowedBooks)
                    .ThenInclude(b => b.Book);
            } 
        }
        

        public async Task<Customer> AddCustomer(Customer newCustomer)
        {
            var customer = await _labb4DbContext.Customers.AddAsync(newCustomer);
            await _labb4DbContext.SaveChangesAsync();
            return customer.Entity;
        }

        public Customer DeleteCustomer(Customer customerToDelete)
        {
            _labb4DbContext.Customers.Remove(customerToDelete);
            _labb4DbContext.SaveChanges();
            return customerToDelete;
        }

        public IEnumerable<BorrowedBook> GetBooks(int id)
        {
            return _labb4DbContext.BorrowedBooks.Where(c => c.CustomerId == id);
        }

        public Customer GetCustomer(int id)
        {
            return _labb4DbContext.Customers
                .Include(b => b.BorrowedBooks)
                .ThenInclude(b => b.Book)
                .FirstOrDefault(i => i.CustomerId == id);
        }

        public Customer UpdateCustomer(Customer customerToUpdate)
        {
            var customer = _labb4DbContext.Customers.FirstOrDefault(c => c.CustomerId == customerToUpdate.CustomerId);
            if (customer != null)
            {
                customer.FirstName = customerToUpdate.FirstName;
                customer.LastName = customerToUpdate.LastName;
                customer.Email = customerToUpdate.Email;
                _labb4DbContext.Customers.Update(customer);
                _labb4DbContext.SaveChanges();
            }
            return customer;
        }
    }
}
