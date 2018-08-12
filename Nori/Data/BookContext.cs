using Microsoft.EntityFrameworkCore;
using Nori.Models;

namespace Nori.Data
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        
        public BookContext(DbContextOptions options) : base(options) { }
    }
}
