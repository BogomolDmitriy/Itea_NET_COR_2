using BL;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itea_NET_COR_2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService, ILogger<BooksController> logger)
        {
            _bookService = bookService;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Book> GetAllBooks()
        {
            return _bookService.GetAllBooks();
        }

        [HttpGet("{id}")]
        public Book GetBookByID(Guid id)
        {
            return _bookService.GetByIdBook(id);
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            try
            {
                var result = _bookService.AddBook(book);

                return Created(result.ToString(), book);
            }
            catch(ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public bool UpdateBook(Guid id, Book book)
        {
            book.Id = id;
            return _bookService.UpdeteBook(book);
        }

        [HttpDelete("{id}")]
        public bool DeleteBook(Guid id)
        {
            return _bookService.DeleteBookById(id);
        }
    }
}
