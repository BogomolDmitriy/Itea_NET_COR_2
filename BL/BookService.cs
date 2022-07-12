using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BookService : IBookService
    {
        private readonly IBooksRepository _booksRepository;

        public BookService (IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        public Guid AddBook(Book book)
        {
            ValidateBookState(book);

            return _booksRepository.Add(book);
        }

        public bool DeleteBookById(Guid id)
        {
            return _booksRepository.DeleteById(id);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _booksRepository.GetAll();
        }

        public Book GetByIdBook(Guid id)
        {
            return _booksRepository.GetById(id);
        }

        public bool UpdeteBook(Book book)
        {
            ValidateBookState(book);
            return _booksRepository.Updete(book);
        }

        private static void ValidateBookState(Book book)
        {
            if (book.PegesCount < 10 || book.PegesCount > 10_000)
            {
                throw new ArgumentException("Invalid pages Count!");
            }
        }
    }
}
