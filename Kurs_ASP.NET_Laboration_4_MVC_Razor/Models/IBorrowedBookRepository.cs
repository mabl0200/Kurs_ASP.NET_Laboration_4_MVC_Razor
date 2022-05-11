using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs_ASP.NET_Laboration_4_MVC_Razor.Models
{
    public interface IBorrowedBookRepository
    {
        IEnumerable<BorrowedBook> GetAllLoans { get; }

        void AddLoan(BorrowedBook borrowedBook);
    }
}
