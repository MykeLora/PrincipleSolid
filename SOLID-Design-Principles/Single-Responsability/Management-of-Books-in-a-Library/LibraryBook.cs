public class LibraryBook
{
    public string? Title { get; set;}
    public string? Author { get; set;}
    public int ISBN { get; set;}

    public void AddBook()
    {
        Console.WriteLine("Book Added to the Library");   
    }

    public void DeleteBook()
    {
        Console.WriteLine("Book Deleted from the Library");
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Displaying the Book Details");
    }
}