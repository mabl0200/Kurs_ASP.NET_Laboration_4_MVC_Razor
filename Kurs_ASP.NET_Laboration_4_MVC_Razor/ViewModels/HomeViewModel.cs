using Kurs_ASP.NET_Laboration_4_MVC_Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs_ASP.NET_Laboration_4_MVC_Razor.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
