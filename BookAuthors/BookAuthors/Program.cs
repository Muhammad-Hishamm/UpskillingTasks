using BookAuthors.Models;

namespace BookAuthors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext context = new AppDbContext();
            AppInitializer.Seed(context);

            #region Add a new author with at least 2 books.


            var newAuthor = new Author
            {
                Name = "Muhammad Taha",
                Email = "muhammadtaha@gmail.com",
                Books = new List<Book>
                {
                    new Book { Title = "l2 bt3m el flamenko", PublishedYear = 2020 },
                    new Book { Title = "zakar sharkqy monkared", PublishedYear = 2022 },
                    new Book { Title = "el 5roog 3n el nas", PublishedYear = 2021 }
                }
            };

            #endregion
            context.Authors.Add(newAuthor);
            context.SaveChanges();
            #region MyRegion
            var authors = context.Authors.Select(author => new
            {
                authId = author.AuthorId,
                authorName = author.Name,
                books = author.Books,
                authEmail = author.Email,

            });


            foreach (var author in authors)
            {
                Console.WriteLine($"Author ID: {author.authId}, Name: {author.authorName}, Email: {author.authEmail}");
                foreach (var book in author.books)
                {
                    Console.WriteLine($"\tBook Title: {book.Title}, Published Year: {book.PublishedYear}");
                }
            }

            #endregion
        }
    }
}
