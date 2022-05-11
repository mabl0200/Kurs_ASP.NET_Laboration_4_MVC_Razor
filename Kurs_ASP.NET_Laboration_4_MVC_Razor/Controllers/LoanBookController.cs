using Kurs_ASP.NET_Laboration_4_MVC_Razor.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs_ASP.NET_Laboration_4_MVC_Razor.Controllers
{
    public class LoanBookController : Controller
    {
        private readonly IBorrowedBookRepository _bookRepository;

        public LoanBookController(IBorrowedBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
