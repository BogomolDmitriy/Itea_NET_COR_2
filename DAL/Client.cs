using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Client
    {
        public Guid id { get; set; }
        public string FirstName { get; set; }
        public string LasteName { get; set; }
        public int MyProperty { get; set; }
    }
}
