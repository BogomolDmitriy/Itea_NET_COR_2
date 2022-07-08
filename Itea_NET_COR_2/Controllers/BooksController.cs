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
        private static List<Book> _book = new List<Book>();
        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Book> GetAllBooks()
        {
            return _book;
        }
    }
}
