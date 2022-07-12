using DAL;
using System;
using System.Collections.Generic;

namespace BL
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        Book GetByIdBook(Guid id);
        bool DeleteBookById(Guid id);
        bool UpdeteBook(Book book);
        Guid AddBook(Book book);
    }
}
