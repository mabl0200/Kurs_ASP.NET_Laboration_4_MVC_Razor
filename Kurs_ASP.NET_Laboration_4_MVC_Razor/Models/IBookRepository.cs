using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs_ASP.NET_Laboration_4_MVC_Razor.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll {get;}

        IEnumerable<Book> GetAvailibleBooks { get; }

        Book GetBookById(int id);
    }
}
