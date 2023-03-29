namespace LibraryIterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library
            (
                new Book("Animal Farm", 2003, "George Orwell"),
                new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace"),
                new Book("The Documents in the Case", 1930)
            );

            foreach (var book in library)
            {
                Console.WriteLine(book);
            }
        }
    }
}