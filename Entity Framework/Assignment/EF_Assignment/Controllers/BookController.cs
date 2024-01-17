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
            try
            {
                this.bookRepository = bookRepository;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost,Route("AddBooks")]
        public IActionResult AddBook(Book book)
        {
            try
            {
                bookRepository.AddBook(book);
                return Ok(book);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetAllBooks")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(bookRepository.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetBookByAuthor/{author}")]
        public IActionResult GetBookByAuthor(string author)
        {
            try
            {
                return Ok(bookRepository.GetBooksByAuthor(author));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetBooksByLang")]
        public IActionResult GetBooksByLang(string lang)
        {
            try
            {
                return Ok(bookRepository.GetBooksByLang(lang));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetBooksByYear")]
        public IActionResult GetBooksByYear(int year)
        {
            try
            {
                return Ok(bookRepository.GetBooksByYear(year));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut,Route("EditBook")]
        public IActionResult EditBook(Book book)
        {
            try
            {
                bookRepository.EditBook(book);
                return Ok(book);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete,Route("DeleteBook")]
        public IActionResult DeleteBook(int id)
        {
            try
            {
                bookRepository.DeleteBook(id);
                return Ok("Book deleted successfully");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
