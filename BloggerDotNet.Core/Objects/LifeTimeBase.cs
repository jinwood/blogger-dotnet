using System;
using BloggerDotNet.Core.Interfaces;

namespace BloggerDotNet.Core.Objects
{
    public class LifeTimeBase : IDirty, ISoftDeletable
    {
        public DateTime? DateDeleted { get; set; }
        public bool IsDirty { get; set; }

        public LifeTimeBase()
        {
            DateDeleted = null;
        }

        public void SoftDelete()
        {
            DateDeleted = DateTime.UtcNow;
        }

        public void MarkClean()
        {
            IsDirty = false;
        }
    }
}
