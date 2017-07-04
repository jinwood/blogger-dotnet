using BloggerDotNet.Core.Interfaces;
using MarkdownSharp;

namespace BloggerDotNet.Infrastructure
{
    public class MarkdownProcessor : IMarkdownProcessor
    {
        public string ConvertToHTML(string md)
        {
            var markDown = new Markdown();
            return markDown.Transform(md);
        }
    }
}
