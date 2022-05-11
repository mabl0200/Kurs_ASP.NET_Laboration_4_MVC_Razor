using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs_ASP.NET_Laboration_4_MVC_Razor.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Author { get; set; }
        
        [Required]
        public string ISBN { get; set; }

        public string ImageThumbnail { get; set; }

        [Required]
        public bool IsAvailable { get; set; }

        //En bok kan lånas av många Customers
        public ICollection<BorrowedBook> BorrowedBooks { get; set; }


    }
}
