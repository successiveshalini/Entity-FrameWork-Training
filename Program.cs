using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApproachDataBase1
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            using (EntityCodeFirstContext context = new EntityCodeFirstContext())
            { 

                var per = new Person() { FirstName = "Shalini", LastName = "Kumari", PersonId = 101 };
                context.Persons.Add(per);
                context.SaveChanges();
                Console.WriteLine("Person Added");
                //Console.ReadKey();
            }
            //using (EntityCodeFirstContext context = new EntityCodeFirstContext())
            //{

            //    var book1 = new Book() {BookId = 1, Title = "BookSearch"};
            //    context.Books.Add(book1);
            //    //context.SaveChanges();  
            //    Console.WriteLine("Book Added");
            //    Console.ReadKey();
            //}
            using (EntityCodeFirstContext context = new EntityCodeFirstContext())
            {

                var auth = new Author() {FirstName = "Soni", LastName = "Kumari", AuthorId = 1 };
                context.Authors.Add(auth);  
                context.SaveChanges();
                Console.WriteLine("Author Added");
                //Console.ReadKey();
            }


        }
    }
}
