using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs_ASP.NET_Laboration_4_MVC_Razor.Models
{
    public class Labb4DbContext : DbContext
    {
        public Labb4DbContext(DbContextOptions<Labb4DbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }

        public DbSet<BorrowedBook> BorrowedBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Data Books
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 1, Name = "Harry Potter och de vises sten", Author = "J.K. Rowling", ISBN = "9789129723946", IsAvailable = true, ImageThumbnail = "\\Labb4Images\\harry-potter-och-de-vises-sten.jpg"});
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 2, Name = "Bära och brista : andra Monikabok", Author = "Sara Lövestam", ISBN = "9789164207937", IsAvailable = true, ImageThumbnail = "\\Labb4Images\\bara-och-brista-andra-monikabok.jpg"});
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 3, Name = "God of Small Things", Author = "Arundhati Roy", ISBN = "9780006550686", IsAvailable = true, ImageThumbnail = "\\Labb4Images\\god-of-small-things.jpg" });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 4, Name = "Hobbiten : eller Bort och hem igen", Author = "J.R.R. Tolkien", ISBN = "9789113084893", IsAvailable = true, ImageThumbnail = "\\Labb4Images\\hobbiten-eller-bort-och-hem-igen.jpg" });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 5, Name = "En aguas tranquilas", Author = "Viveca Sten", ISBN = "9788416087631", IsAvailable = true, ImageThumbnail = "\\Labb4Images\\i-de-lugnaste-vatten.jpg" });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 6, Name = "The Awakening", Author = "Kate Chopin", ISBN = "9781847498250", IsAvailable = true, ImageThumbnail = "\\Labb4Images\\the-awakening.jpg" });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 7, Name = "The C# Player's Guide (4th Edition)", Author = "RB Whitaker", ISBN = "9780985580148", IsAvailable = true, ImageThumbnail = "\\Labb4Images\\the-c-players-guide-4th-edition.jpg" });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 8, Name = "Hur jag lärde mig förstå världen", Author = "Hans Rosling", ISBN = "9789127166356", IsAvailable = true, ImageThumbnail = "\\Labb4Images\\hur-jag-larde-mig-forsta-varlden.jpg" });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 9, Name = "Kvinnor jag tänker på om natten", Author = "Mia Kankimäki", ISBN = "9789146239307", IsAvailable = true, ImageThumbnail = "\\Labb4Images\\kvinnor-jag-tanker-pa-om-natten.jpg" });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 10, Name = "Där kräftorna sjunger", Author = "Delia Owens", ISBN = "9789137157726", IsAvailable = true, ImageThumbnail = "\\Labb4Images\\dar-kraftorna-sjunger.jpg" });

            //Seed Data Customer
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 1, FirstName = "Margit", LastName = "Danielsson", Email = "margit@hello.se" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 2, FirstName = "Teresa", LastName = "Gustavsson", Email = "teresa@hello.se" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 3, FirstName = "Emmy", LastName = "Ahlgren", Email = "emmy@hello.se" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 4, FirstName = "Jennie", LastName = "Svensson", Email = "jennie@hello.se" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 5, FirstName = "Christine", LastName = "Jönsson", Email = "christine@hello.se" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 6, FirstName = "Mats", LastName = "Nyquist", Email = "mats@hello.se" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 7, FirstName = "Linus", LastName = "Olsson", Email = "linus@hello.se" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 8, FirstName = "Carl", LastName = "Hamilton", Email = "carl@hello.se" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 9, FirstName = "Robert", LastName = "Skog", Email = "robert@hello.se" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 10, FirstName = "Andreas", LastName = "Östberg", Email = "andreas@hello.se" });


        }
    }
}
