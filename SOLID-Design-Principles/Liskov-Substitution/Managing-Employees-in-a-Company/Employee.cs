public class Employees : IBonusProvider
{
    public double Salary { get; set;}
    public virtual double CalculateBonus()
    {
        return Salary * 0.1;
    }
}
