using BloggerDotNet.Core.Interfaces;
using System;

namespace BloggerDotNet.Core.Objects
{
    public class Post
    {
        public int PostId { get; set; }
        public string Reference { get; }

        public string MdContent { get; set; }
        public string HTMLContent { get; set; }

        public DateTime DateCreated { get; }
        public DateTime DateDeleted { get; set; }

        public Post(DateTime dateCreated, IReferenceGenerator referenceGenerator)
        {
            DateCreated = dateCreated;
            Reference = referenceGenerator.CreateReference(Constants.CryptographicReferenceLength);
        }
    }
}
