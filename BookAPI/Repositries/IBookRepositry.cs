using BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Repositries
{
    public interface IBookRepositry
    {
        Task<IEnumerable<Book>> Get();
        Task<Book> Get(int id);

    }
}
