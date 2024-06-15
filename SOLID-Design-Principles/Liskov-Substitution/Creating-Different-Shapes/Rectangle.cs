public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    
    public override double GetArea()
    {
        return Width * Height;
    }

    public void ChangeDimensions(Rectangle rect, double width, double height)
    {
        rect.Width = width;
        rect.Height = height;
        Console.WriteLine($"Area: {rect.GetArea()}");
    }
}
