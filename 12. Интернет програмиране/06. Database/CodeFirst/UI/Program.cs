using Data;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                // Add Book, Author and Biography to the database
                using (var context = new DataContext())
                {
                    context.Database.EnsureCreated();

                    context.Biographies.Add(new Data.Entity.Biography
                    {
                        BiographyData = "Author of Hitchhiker's Guide to the Galaxy",
                        DateOfBirth = new System.DateTime(1979, 10, 12),
                        PlaceOfBirth = "London",
                        Nationality = "United Kindom",
                        AuthorId = 1
                    });

                    context.Authors.Add(new Data.Entity.Author
                    {
                        FirstName = "Adam",
                        LastName = "Duglas",
                        BiographyId = 1
                    });

                    context.Books.Add(new Data.Entity.Book
                    {
                        Title = "Hitchhiker's Guide to the Galaxy",
                        AuthorId = 1
                    });

                    context.SaveChanges();
                }
            */

            // Read Book and Author from the database    
            using (var context = new DataContext())
            {
                var books = context.Books.ToList();
                foreach (var book in books)
                {
                    var author = context.Authors.FirstOrDefault(a => a.Id == book.AuthorId);
                    Console.WriteLine($"{author.FirstName} {author.LastName} - {book.Title}");
                }

            }
        }
    }
}
