using Kurs_ASP.NET_Laboration_4_MVC_Razor.Models;
using Kurs_ASP.NET_Laboration_4_MVC_Razor.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs_ASP.NET_Laboration_4_MVC_Razor.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly IBorrowedBookRepository _borrowedBook;

        public BookController(IBookRepository bookRepository, IBorrowedBookRepository borrowedBook)
        {
            _bookRepository = bookRepository;
            _borrowedBook = borrowedBook;

        }
        public IActionResult Index()
        {
            var availibleBooks = new AvailibleBooksViewModel
            {
                Books = _bookRepository.GetAvailibleBooks
            };
            return View(availibleBooks);
        }

        public IActionResult Details(int id)
        {
            var singleBook = _bookRepository.GetBookById(id);
            if (singleBook == null)
            {
                return NotFound();
            }
            return View(singleBook);
        }
    }
}
