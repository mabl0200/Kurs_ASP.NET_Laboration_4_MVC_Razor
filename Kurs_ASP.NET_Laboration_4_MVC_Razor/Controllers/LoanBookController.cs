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
    public class LoanBookController : Controller
    {
        private readonly IBorrowedBookRepository _borrowedBookRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IBookRepository _bookRepository;

        public LoanBookController(IBorrowedBookRepository BorrowedBookRepository, ICustomerRepository customerRepository, IBookRepository bookRepository)
        {
            _borrowedBookRepository = BorrowedBookRepository;
            _customerRepository = customerRepository;
            _bookRepository = bookRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
            //var newList = new LoanBookViewModel();
            //newList.Customers = _customerRepository.GetAllCustomers;
            //newList.Books = _bookRepository.GetAll;

            //return View(newList);
        }
        public IActionResult Details(int id)
        {
            var CustomerBookViewModel = new CustomerBookViewModel
            {
                Customer = _customerRepository.GetCustomer(id),
                Books = _customerRepository.GetBooks(id)
            };
            
            if (CustomerBookViewModel == null)
            {
                return NotFound();
            }
            return View(CustomerBookViewModel);
        }

        [HttpPost]
        [Route("LoanBook/Add")]
        public async Task<ActionResult<BorrowedBook>> AddLoan(BorrowedBook borrowedBook)
        {
            try
            {
                if (borrowedBook == null)
                {
                    return BadRequest();
                }
                var newLoan = await _borrowedBookRepository.AddLoan(borrowedBook);
                var updateBook = _bookRepository.GetBookById(borrowedBook.BookId);
                _bookRepository.UpdateBook(updateBook);
                return newLoan;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error, failed to Create a new object to Database...");
            }
        }
        [Route("LoanBook/Test")]
        public string Test(BorrowedBook borrowedBook)
        {
            return $"Låntagare: {borrowedBook.CustomerId} Bok: {borrowedBook.BookId} Start: {borrowedBook.StartOfLoanPeriod} Slut: {borrowedBook.EndOfLoanPeriod} {borrowedBook.IsReturned}";
        }
    }
}
