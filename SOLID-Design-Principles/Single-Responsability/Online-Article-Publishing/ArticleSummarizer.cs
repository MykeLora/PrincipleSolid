public class ArticleSummarizer
{
    public string GenerateSummary(Article article)
    {
        string summary;

        if (article.Content.Length >= 100)
        {
            summary = string.Concat(article.Content.Substring(0, 100), "...");
        }
        else
        {
            summary = article.Content; 
        }
        return summary;
    }
}