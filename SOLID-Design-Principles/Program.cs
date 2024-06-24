using System;
internal class Program
{
    public static void Main(string[] args)
    {
        EditableDocument editable = new EditableDocument();
        editable.Write("Editable Content");
        editable.Read();

        ReadOnlyDocument read = new ReadOnlyDocument("Read-Only Content");
        read.Read();

        Console.ReadKey();
    }

}