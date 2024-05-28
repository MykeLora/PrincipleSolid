using System;
internal class Program
{
    private static void Main(string[] args)
    {
        var mcQuestion = new Question{
            Title = "Choose a color",
            type = QuestionType.MultipleChoice
        };
        
        var renderer = new SurveyRenderer(new MultipleChoiceRenderer());
        renderer.RenderQuestion(mcQuestion);

        var tfQuestion = new Question { Title = "The sky is blue", type = QuestionType.TrueFalse };
        renderer = new SurveyRenderer(new TrueFalseRenderer());
        renderer.RenderQuestion(tfQuestion);
            
        Console.ReadKey();
    }
}