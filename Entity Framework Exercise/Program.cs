using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyNewCodeFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (EFDbContext context = new EFDbContext())
            {

                var book = new Book1 { BookId = 34, BookName = "python", BookTitle = "C#", };
                context.Books.Add(book);
                context.SaveChanges();
                Console.WriteLine("Book Added");
                Console.ReadKey();  

            }
        }
    }
}
