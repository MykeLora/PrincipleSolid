public class Librarian : IBorrowReturn, ISearchable, IManageInventory
{
    public void AddBook(Book book)
    {
        Console.WriteLine($"Librarian Add Book, {book}");
    }

    public void BorrowBook(string bookId)
    {
        Console.WriteLine($"Librarian Borrow Book, BookId: {bookId}");
    }

    public void RemoveBook(string bookId)
    {
        throw new NotImplementedException();
    }

    public void ReturnBook(string bookId)
    {
       Console.WriteLine($"Librarian Return Book, BookId: {bookId}");
    }

    public void SearchCatalog(string searchTerm)
    {
        Console.WriteLine($"Librarian Search Book, Search Catalog: {searchTerm}");
    }
}
