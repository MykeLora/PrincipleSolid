public class ReadOnlyDocument : IReadable
{
    public ReadOnlyDocument(string content)
    {
        Content = content;
    }

    public string Content { get; }

    public void Read()
    {
       Console.WriteLine(Content);
    }
}
