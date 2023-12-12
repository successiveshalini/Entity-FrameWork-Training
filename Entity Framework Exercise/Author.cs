using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewCodeFirstApproach
{
    
    public class Author
    {
      public int AuthorId { get; set; }
      
      public string Name { get; set; }  

      public virtual ICollection<Book1> Books { get; set; }

    }
}
