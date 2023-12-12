using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewCodeFirstApproach
{
    public class EFDbContext: DbContext
    {
        public EFDbContext() : base()
        { 
        }
        public DbSet<Book1> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
    
}
