using BooksApi.Models;
using Microsoft.AspNetCore.Mvc;
namespace BooksApi.Controllers
{
    //https://localhost:7219/api/books
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private Book[] _books = new Book[]
        {
            new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee" },
            new Book { Id = 3, Title = "1984", Author = "George Orwell" },
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_books);
        }
    }
}
