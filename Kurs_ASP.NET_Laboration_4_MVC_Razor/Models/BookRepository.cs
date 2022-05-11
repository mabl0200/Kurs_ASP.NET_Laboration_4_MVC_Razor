﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs_ASP.NET_Laboration_4_MVC_Razor.Models
{
    public class BookRepository : IBookRepository
    {
        private Labb4DbContext _labb4DbContext;

        public BookRepository(Labb4DbContext labb4DbContext)
        {
            _labb4DbContext = labb4DbContext;
        }

        public IEnumerable<Book> GetAll 
        {
            get
            {
                return _labb4DbContext.Books;
            }
        }

        public IEnumerable<Book> GetAvailibleBooks
        {
            get
            {
                return _labb4DbContext.Books.Where(b => b.IsAvailable == true);
            }
        }


        public Book GetBookById(int id)
        {
            return _labb4DbContext.Books.FirstOrDefault(b => b.BookId == id);
        }
    }
}
