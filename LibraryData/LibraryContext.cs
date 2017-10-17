using LibsData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibsData
{
    public class LibraryContext :DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options) { }

        public DbSet<Patron> Patrons { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<LibraryBranch> LibraryBranches { get; set; }

    }
    
}
