namespace _01._Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Създаваме библиотека 
            Library library = new Library
            (
                new Book("Animal Farm", 2003, "George Orwell"),
                new Book("The document is the case", 2002, "Doroty Sayers", "Robert Eustace"),
                new Book("Developing Cross Platform Apps", 2021, "Dimitar Minchev")
                // Можем да добавим още книги
            );

            // Отпечаваме библитеката
            foreach (var book in library)
            {
                Console.WriteLine(book);
            }
        }
    }
}