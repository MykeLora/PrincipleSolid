public class AdminUser : IReadDocument, IUpdateDocument, IDeleteDocument, ICreaDocument
{
    public void CreateDocument(string content)
    {
        Console.WriteLine($"Create Document: {content}");
    }

    public void DeleteDocument(int id)
    {
       Console.WriteLine($"Delete Document: Id: {id}");
    }

    public string ReadDocument(int id)
    {
        Console.WriteLine($"Read Document: Id: {id}");
        return "Samples document content.";
    }

    public void UpdateDocument(int id, string content)
    {
        Console.WriteLine($"Update Document: Id: {id}, content: {content}");
    }
}
