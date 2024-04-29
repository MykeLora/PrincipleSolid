public class TranscriptGenerator
{
    private readonly GPACalculator gpaCalculator;

    public TranscriptGenerator(GPACalculator gpaCalculator)
    {
        this.gpaCalculator = gpaCalculator;
    }

    public void PrintTranscript(Student student)
    {
        Console.WriteLine($"Transcript for {student.Name}");

        foreach(var course in student.CourseAndGrades)
        {
            Console.WriteLine($"{course.Key}: {course.Value}");

            Console.WriteLine($"GPA: {this.gpaCalculator.Calculator(student)}");
        }
    }
}