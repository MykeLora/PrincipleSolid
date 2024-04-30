internal class Program
{
   
    private static void Main(string[] args)
    {
        LibraryBook book = new LibraryBook
        {
            Title = "Clean Arquitecture",
            Author = "Robert c.Marti",
            ISBN = 14563268
        };

        LibraryLogger logger = new LibraryLogger();
        book.AddBook();
        logger.Log($"Added {book.Title} by {book.Author}");

        book.DeleteBook();
        logger.Log($"Delete {book.Title} by {book.Author}");
        Console.ReadKey();
    }
} 