public class ReadOnlyUser : IReadDocument
{
    public string ReadDocument(int id)
    {
        return "Sample Document Content.";
    }
}
