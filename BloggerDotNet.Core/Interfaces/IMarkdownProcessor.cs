namespace BloggerDotNet.Core.Interfaces
{
    public interface IMarkdownProcessor
    {
        string ConvertToHTML(string md);
    }
}
