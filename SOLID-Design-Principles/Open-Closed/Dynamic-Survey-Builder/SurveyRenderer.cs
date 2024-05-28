public class SurveyRenderer
{
    private readonly IQuestionRenderer question;

    public SurveyRenderer(IQuestionRenderer question)
    {
        this.question = question;
    }
    
    public void RenderQuestion(Question question)
    {
        this.question.Render(question);
    }
}