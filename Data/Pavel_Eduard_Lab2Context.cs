using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pavel_Eduard_Lab2.Models;

namespace Pavel_Eduard_Lab2.Data
{
    public class Pavel_Eduard_Lab2Context : DbContext
    {
        public Pavel_Eduard_Lab2Context (DbContextOptions<Pavel_Eduard_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Pavel_Eduard_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Pavel_Eduard_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Pavel_Eduard_Lab2.Models.Author> Author { get; set; }

        public DbSet<Pavel_Eduard_Lab2.Models.Category> Category { get; set; }

        public DbSet<Pavel_Eduard_Lab2.Models.Member> Member { get; set; }

        public DbSet<Pavel_Eduard_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
