using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using app_of_apps_be.Models;
using Microsoft.EntityFrameworkCore;

namespace app_of_apps_be.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
        private readonly LibraryDbContext _context;

        public BookController(LibraryDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            var books = _context.Books;
            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult GetBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost]
        public IActionResult CreateBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetBook), new { id = book.id }, book);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, Book updatedBook)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            book.title = updatedBook.title;
            book.author = updatedBook.author;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = _context.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.Books.Remove(book);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
