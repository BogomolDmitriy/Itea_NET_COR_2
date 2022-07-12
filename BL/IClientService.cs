using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IClientService
    {
        bool RentABook(BookService book, Client client);
        bool ReturnABook(BookService book, Client client);


    }
}
