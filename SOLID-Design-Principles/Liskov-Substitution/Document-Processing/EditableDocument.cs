public class EditableDocument : IReadable, IWritable
{
    public string? Content { get; set;}

    public void Read()
    {
        Console.WriteLine(Content);
    }

    public void Write(string content)
    {
        Content = content;
    }
}
