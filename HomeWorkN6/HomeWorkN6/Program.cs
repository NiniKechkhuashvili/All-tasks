namespace HomeWorkN6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library(5);

            Book book1 = new Book("Tom Sawyer", "Mark Twain", 1876);
            Book book2 = new Book("Igi", "Jemal Qarchkhadze", 1977);
            Book book3 = new Book("Brown Wolf", "Jack London", 1906);
            Book book4 = new Book("Tom Sawyer", "Mark Twain", 1920);

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

            Console.WriteLine("All books in the library:");
            library.PrintBooks();

            Console.WriteLine($"Total books in the library: {library.Count}");

            string searchTitle = "Tom Sawyer";
            Console.WriteLine($"Searching for books with title '{searchTitle}':");
            library.FindBook(searchTitle);

            string removeTitle = "Brown Wolf";
            library.RemoveBook(removeTitle);

            Console.WriteLine($"All books in the library after removing '{removeTitle}':");
            library.PrintBooks();

            Console.WriteLine($"Total books in the library: {library.Count}");
        }
    }
}
