using EF_Assignment.Entities;
using EF_Assignment.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EF_Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private BookRepository bookRepository;

        public BookController(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        [HttpPost,Route("AddBooks")]
        public IActionResult AddBook(Book book)
        {
            bookRepository.AddBook(book);
            return Ok(book);
        }
        [HttpGet,Route("GetAllBooks")]
        public IActionResult GetAll()
        {
            return Ok(bookRepository.GetAll());
        }
        [HttpGet,Route("GetBookByAuthor/{author}")]
        public IActionResult GetBookByAuthor(string author)
        {
            return Ok(bookRepository.GetBooksByAuthor(author));
        }
        [HttpGet,Route("GetBooksByLang")]
        public IActionResult GetBooksByLang(string lang)
        {
            return Ok(bookRepository.GetBooksByLang(lang));
        }
        [HttpGet,Route("GetBooksByYear")]
        public IActionResult GetBooksByYear(int year)
        {
            return Ok(bookRepository.GetBooksByYear(year));
        }
        [HttpPut,Route("EditBook")]
        public IActionResult EditBook(Book book)
        {
            bookRepository.EditBook(book);
            return Ok(book);
        }
        [HttpDelete,Route("DeleteBook")]
        public IActionResult DeleteBook(int id)
        {
            bookRepository.DeleteBook(id);
            return Ok("Book deleted successfully");
        }
    }
}
