using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itea_NET_COR_2
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Autor { get; set; }
        public int PegesCount { get; set; }
    }
}
