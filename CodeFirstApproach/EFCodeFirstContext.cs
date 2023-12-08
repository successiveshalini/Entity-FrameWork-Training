using System.Data.Entity;

namespace EFCodeFirstDataBase
{
    internal class EFCodeFirstContext : DbContext
    {
        public EFCodeFirstContext() : base() 
        {
        }
        public DbSet<Student> Students { get; set; }    
        public DbSet<Standard> Standards { get; set; }
    }
}