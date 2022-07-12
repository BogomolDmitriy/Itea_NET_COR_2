using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IBooksRepository
    {
        IEnumerable<Book> GetAll();
        Book GetById(Guid id);
        bool DeleteById(Guid id);
        bool Updete(Book book);
        Guid Add(Book book);
    }
}
