using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs_ASP.NET_Laboration_4_MVC_Razor.Models
{
    public class BorrowdBookRepository : IBorrowedBookRepository
    {
        private Labb4DbContext _labb4DbContext;
        public BorrowdBookRepository(Labb4DbContext labb4DbContext)
        {
            _labb4DbContext = labb4DbContext;
        }

        public IEnumerable<BorrowedBook> GetAllLoans
        {
            get
            {
                return _labb4DbContext.BorrowedBooks;
            }
        }

        public void AddLoan(BorrowedBook borrowedBook)
        {
            throw new NotImplementedException();
        }
    }
}
