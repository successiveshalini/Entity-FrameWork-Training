using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDemoProject
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // configures one-to-many relationship
            modelBuilder.Entity<Student>()
                .HasRequired<Grade>(s => s.CurrentGrade)
                .WithMany(g => g.Students)
                .HasForeignKey<int>(s => s.CurrentGradeId);

           modelBuilder.Entity<Grade>()
          .HasMany<Student>(g => g.Students)
          .WithRequired(s => s.CurrentGrade)
          .HasForeignKey<int>(s => s.CurrentGradeId);

            modelBuilder.Entity<Student>()
           .HasRequired<Grade>(s => s.CurrentGrade)
           .WithMany(g => g.Students);

            modelBuilder.Entity<Grade>()
           .HasMany<Student>(g => g.Students)
          .WithRequired(s => s.CurrentGrade)
          .WillCascadeOnDelete();



        }

    }
}
