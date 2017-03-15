using System;

namespace BloggerDotNet.Core.Interfaces
{
    public interface ISoftDeletable
    {
        DateTime? DateDeleted { get; set; }
        void SoftDelete();
    }
}
