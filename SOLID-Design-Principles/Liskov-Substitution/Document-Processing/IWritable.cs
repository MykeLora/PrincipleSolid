public interface IWritable
{
    string? Content { get; set; }
    void Write(string content);
}