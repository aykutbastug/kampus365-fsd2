using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Book> Books { get; set; }
    }
}
