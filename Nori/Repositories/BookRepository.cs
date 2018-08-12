using System.Linq;
using Microsoft.EntityFrameworkCore;
using Nori.Data;
using Nori.Models;

namespace Nori.Repositories
{
    public class BookRepository : IRepository<Book>
    {
        private readonly BookContext _bookContext;

        private DbSet<Book> Set => _bookContext.Books;

        public BookRepository(BookContext bookContext)
        {
            _bookContext = bookContext;
        }

        public IQueryable<Book> GetAll()
        {
            return Set;
        }
    }
}
