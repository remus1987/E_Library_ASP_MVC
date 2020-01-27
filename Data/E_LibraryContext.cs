using E_Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Library.Data
{
    public class E_LibraryContext : DbContext
    {
        public E_LibraryContext(DbContextOptions<E_LibraryContext> options)
             : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
    }
}
