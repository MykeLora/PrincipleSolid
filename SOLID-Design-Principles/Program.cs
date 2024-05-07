using System;

internal class Program
{
   
    public static void Main()
    {
        Article newArticle = new Article
            {
                Title = "The Benefits of SRP",
                Content = "A long content about the Single Responsibility Principle..."
            };
            ArticleDatabaseManager dbManager = new ArticleDatabaseManager();
            dbManager.SaveArticle(newArticle);
            ArticleSummarizer summarizer = new ArticleSummarizer();
            string summary = summarizer.GenerateSummary(newArticle);
          
        Console.ReadKey();
    }
} 