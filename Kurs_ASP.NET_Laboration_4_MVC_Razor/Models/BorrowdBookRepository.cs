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
                return _labb4DbContext.BorrowedBooks
                    .Include(b => b.Book);
            }
        }

        public async Task<BorrowedBook> AddLoan(BorrowedBook borrowedBook)
        {
            var loan = await _labb4DbContext.BorrowedBooks.AddAsync(borrowedBook);
            await _labb4DbContext.SaveChangesAsync();
            return loan.Entity;
        }
    }
}
