using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNewCodeFirstApproach
{
    public class Book1
    {
        [Key]
        public int BookId { get; set; }
        [Required]  
        public string BookName{ get; set; }
        [Required]  
        public string BookTitle { get; set; }
        public virtual ICollection<Person> Books { get; set; }
    }
}
