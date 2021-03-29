using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_Hw.Models;
using Microsoft.EntityFrameworkCore;

namespace Book_Hw.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Book> Book { get; set; }
        public DbSet<Book_description> Book_Description { get; set; }
        public DbSet<User> User {get; set;}
    }
}
