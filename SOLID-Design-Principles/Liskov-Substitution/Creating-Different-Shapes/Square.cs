public class Square : Shape
{
    public double Slide { get; set; }

    
    public override double GetArea()
    {
       return Slide * Slide;
    }
}
