using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAuthors.Models
{
    internal class Author
    {
        //AuthorId (PK), Name, Email

        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
