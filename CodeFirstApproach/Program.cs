using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstDataBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (EFCodeFirstContext context = new EFCodeFirstContext())
            {
                var stud = new Student() { FirstName = "Shalini", LastName = "Kumari" };
                context.Students.Add(stud);
                context.SaveChanges();
                Console.WriteLine("Student Added");
                //Console.ReadKey();
            }
            using (EFCodeFirstContext context = new EFCodeFirstContext())
            {
                var Stan = new Standard() { StandardId = 120, StandardName = "Three", Description = "USA"};
                context.Standards.Add(Stan);
                context.SaveChanges();
                Console.WriteLine("Standard Added");
                Console.ReadKey();
            }


        }
    }
}
