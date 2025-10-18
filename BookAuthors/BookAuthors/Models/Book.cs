using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace BookAuthors.Models
{
    internal class Book
    {
        //  BookId (PK), Title, PublishedYear, AuthorId (FK)
        public int BookId { get; set; }
        public string Title { get; set; }
        public int PublishedYear { get; set; }


        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
