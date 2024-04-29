public class GPACalculator
{
    public double Calculator(Student student)
    {
        return student.CourseAndGrades.Values.Average();
    }
    
}