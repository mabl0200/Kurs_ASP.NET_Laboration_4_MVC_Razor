using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs_ASP.NET_Laboration_4_MVC_Razor.Models
{
    public class BorrowedBook
    {
        [Key]
        public int BorrowedBookId { get; set; }

        [Required]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public bool IsReturned { get; set; }

        public DateTime? StartOfLoanPeriod { get; set; }
        public DateTime? EndOfLoanPeriod { get; set; }
    }
}
