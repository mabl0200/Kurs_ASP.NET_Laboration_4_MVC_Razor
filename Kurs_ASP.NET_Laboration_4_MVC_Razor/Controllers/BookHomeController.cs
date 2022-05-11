using Kurs_ASP.NET_Laboration_4_MVC_Razor.Models;
using Kurs_ASP.NET_Laboration_4_MVC_Razor.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs_ASP.NET_Laboration_4_MVC_Razor.Controllers
{
    public class BookHomeController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BookHomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public IActionResult Index()
        {
            var listOfBooks = new HomeViewModel();
            listOfBooks.Books = _bookRepository.GetAll;
            return View(listOfBooks);
        }
    }
}
