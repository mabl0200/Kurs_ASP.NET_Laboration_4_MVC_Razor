using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs_ASP.NET_Laboration_4_MVC_Razor.Models
{
    public interface ICustomerRepository
    {
        //Du ska hämta alla Customers som är i DB
        IEnumerable<Customer> GetAllCustomers { get; }

        //Du ska hämta en specifik Customer med sin id
        Customer GetCustomer(int id);

        //Vi vill kunna editera, skapa och ta bort en Customer
        Task<Customer> AddCustomer(Customer newCustomer);

        Customer UpdateCustomer(Customer customerToUpdate);

        Customer DeleteCustomer(Customer customerToDelete);
        

        //Vi vill se alla böcker som en Customer har lånat
        IEnumerable<BorrowedBook> GetBooks(int id);

    }
}
