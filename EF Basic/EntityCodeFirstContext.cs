using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproachDataBase1
{
    public class EntityCodeFirstContext:DbContext
    {
        public EntityCodeFirstContext() : base()
        {
        }
        //Adding Domain Classes as DbSet
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Person> Persons { get; set; }

    }
}
