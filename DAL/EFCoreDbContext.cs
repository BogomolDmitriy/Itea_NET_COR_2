using Microsoft.EntityFrameworkCore;
using System;

namespace DAL
{
    public class EFCoreDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public EFCoreDbContext(DbContextOptions<EFCoreDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
