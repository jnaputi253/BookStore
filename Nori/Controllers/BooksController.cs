using Microsoft.AspNetCore.Mvc;
using Nori.Models;
using Nori.Repositories;

namespace Nori.Controllers
{
    [Route("api/[controller]")]
    public class BooksController
    {
        private readonly IRepository<Book> _bookRepository;

        public BooksController(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult All()
        {
            return new OkObjectResult(_bookRepository.GetAll());
        }
    }
}
