using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DAL
{
    public class Book
    {
        public Guid Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Title { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(40)]
        public string Autor { get; set; }
        public int PegesCount { get; set; }
    }
}
