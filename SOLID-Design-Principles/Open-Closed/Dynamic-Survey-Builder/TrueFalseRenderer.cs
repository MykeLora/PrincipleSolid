public class TrueFalseRenderer : IQuestionRenderer
{
    public void Render(Question question)
    {
       Console.WriteLine($"Rendering open text question: {question.Title}");
       
    }
}
 