using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewCodeFirstApproach
{
    public class Person
    {
      public int personId { get; set; }
     public string FirstName { get; set; }   
     public string LastName { get; set; }  
      public virtual ICollection<Book1> BookIssued { get; set; }
    }
}
