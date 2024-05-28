public class MultipleChoiceRenderer : IQuestionRenderer
{
    public void Render(Question question)
    {
        Console.WriteLine($"Rendering multiple choice question: {question.Title} ");
    }
}
