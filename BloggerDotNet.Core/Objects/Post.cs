using System;

namespace BloggerDotNet.Core.Objects
{
    public class Post
    {
        public int PostId { get; }
        public string Reference { get; set; }

        public string MdContent { get; set; }
        public string HTMLContent { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateDeleted { get; set; }

        public Post()
        {
        }
    }
}
