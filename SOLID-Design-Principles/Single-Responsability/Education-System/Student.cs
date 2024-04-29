public class Student
{
    public string? Name { get;set; }
    public Dictionary<string, double> CourseAndGrades = new Dictionary<string, double>();

    public void EnrollCourse(string courseName)
    {
        CourseAndGrades[courseName] = 0;
    }

    public void AssignGrade(string courseName, double grade)
    {
        if(CourseAndGrades.ContainsKey(courseName))
        {
            CourseAndGrades[courseName] = grade;
        }

    }

}    