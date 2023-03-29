namespace Library
{
    public class Library 
    {
        public List<Book> books { get; set; }

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }
    }
}