internal class Program
{
   
    private static void Main(string[] args)
    {
        Student Maycol = new Student {Name = "Maycol"};
        Maycol.EnrollCourse("Programación II");
        Maycol.AssignGrade("Programación II", 91);

        GPACalculator gpaCalc = new GPACalculator();
        TranscriptGenerator transcript = new TranscriptGenerator(gpaCalc);
        transcript.PrintTranscript(Maycol);
        
        Console.ReadKey();
    }
} 