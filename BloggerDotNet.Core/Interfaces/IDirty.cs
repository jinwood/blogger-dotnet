namespace BloggerDotNet.Core.Interfaces
{
    public interface IDirty
    {
        bool IsDirty { get; set; }
        void MarkClean();
    }
}
