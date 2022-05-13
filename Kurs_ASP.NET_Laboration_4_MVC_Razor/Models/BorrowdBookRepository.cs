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
                    .Include(b => b.Book)
                    .Include(c => c.Customer);
            }
        }

        public async Task<BorrowedBook> AddLoan(BorrowedBook borrowedBook)
        {
            var loan = await _labb4DbContext.BorrowedBooks.AddAsync(borrowedBook);
            await _labb4DbContext.SaveChangesAsync();
            return loan.Entity;
        }
        public BorrowedBook GetLoanById(int id)
        {
            return _labb4DbContext.BorrowedBooks.FirstOrDefault(l => l.BorrowedBookId == id);
        }

        public BorrowedBook UpdateLoan(BorrowedBook borrowedBook)
        {
            var loan = _labb4DbContext.BorrowedBooks.FirstOrDefault(loan => loan.BorrowedBookId == borrowedBook.BorrowedBookId);
            if (loan != null)
            {
                
                loan.IsReturned = true;
                loan.EndOfLoanPeriod = loan.EndOfLoanPeriod;
                _labb4DbContext.BorrowedBooks.Update(loan);
                _labb4DbContext.SaveChanges();
                
            }
            return loan;
        }
    }
}
