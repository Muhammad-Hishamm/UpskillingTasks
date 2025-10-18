using BookAuthors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAuthors
{
    internal static class AppInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (context.Authors.Any()) return;

            var authors = new List<Author>
        {
            new Author
            {
                Name = "George Orwell",
                Email = "orwell@literature.com",
                Books = new List<Book>
                {
                    new Book { Title = "1984", PublishedYear = 1949 },
                    new Book { Title = "Animal Farm", PublishedYear = 1945 },
                    new Book { Title = "Homage to Catalonia", PublishedYear = 1938 },
                    new Book { Title = "Down and Out in Paris and London", PublishedYear = 1933 },
                    new Book { Title = "The Road to Wigan Pier", PublishedYear = 1937 }
                }
            },
            new Author
            {
                Name = "Jane Austen",
                Email = "austen@classics.org",
                Books = new List<Book>
                {
                    new Book { Title = "Pride and Prejudice", PublishedYear = 1813 },
                    new Book { Title = "Sense and Sensibility", PublishedYear = 1811 },
                    new Book { Title = "Emma", PublishedYear = 1815 },
                    new Book { Title = "Mansfield Park", PublishedYear = 1814 },
                    new Book { Title = "Persuasion", PublishedYear = 1817 }
                }
            },
            new Author
            {
                Name = "Naguib Mahfouz",
                Email = "mahfouz@arabiclit.eg",
                Books = new List<Book>
                {
                    new Book { Title = "Palace Walk", PublishedYear = 1956 },
                    new Book { Title = "Palace of Desire", PublishedYear = 1957 },
                    new Book { Title = "Sugar Street", PublishedYear = 1957 },
                    new Book { Title = "The Thief and the Dogs", PublishedYear = 1961 },
                    new Book { Title = "Children of the Alley", PublishedYear = 1959 }
                }
            },
            new Author
            {
                Name = "Gabriel García Márquez",
                Email = "marquez@magicrealism.co",
                Books = new List<Book>
                {
                    new Book { Title = "One Hundred Years of Solitude", PublishedYear = 1967 },
                    new Book { Title = "Love in the Time of Cholera", PublishedYear = 1985 },
                    new Book { Title = "Chronicle of a Death Foretold", PublishedYear = 1981 },
                    new Book { Title = "The Autumn of the Patriarch", PublishedYear = 1975 },
                    new Book { Title = "Of Love and Other Demons", PublishedYear = 1994 }
                }
            },
            new Author
            {
                Name = "Haruki Murakami",
                Email = "murakami@modernjapan.jp",
                Books = new List<Book>
                {
                    new Book { Title = "Norwegian Wood", PublishedYear = 1987 },
                    new Book { Title = "Kafka on the Shore", PublishedYear = 2002 },
                    new Book { Title = "1Q84", PublishedYear = 2009 },
                    new Book { Title = "The Wind-Up Bird Chronicle", PublishedYear = 1994 },
                    new Book { Title = "After Dark", PublishedYear = 2004 }
                }
            }
        };

            context.Authors.AddRange(authors);
            context.SaveChanges();
        }
    }
}
