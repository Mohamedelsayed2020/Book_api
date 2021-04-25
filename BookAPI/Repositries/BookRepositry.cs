using BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Repositries
{
    public class BookRepositry : IBookRepositry
    {
        private readonly BookContext _context;

        public BookRepositry(BookContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Book>> Get()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> Get(int id)
        {
            return await _context.Books.FindAsync(id);
        }
    }
}
