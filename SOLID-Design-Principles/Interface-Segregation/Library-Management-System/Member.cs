public class Member : IBorrowReturn, ISearchable
{
    public void BorrowBook(string bookId)
    {
        Console.WriteLine($"Member Borrow Book, BookId: {bookId}");
    }

    public void ReturnBook(string bookId)
    {
        Console.WriteLine($"Member Return Book, BookId: {bookId}");
    }

    public void SearchCatalog(string searchTerm)
    {
        Console.WriteLine($"Member Search Book, Search Catalog: {searchTerm}");
    }
}
