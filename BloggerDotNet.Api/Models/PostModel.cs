using System;

namespace BloggerDotNet.Api.Models
{
    public class PostModel
    {
        public string Reference { get; }

        public string MdContent { get; set; }
        public string HTMLContent { get; set; }

        public DateTime DateCreated { get; }
        public DateTime DateDeleted { get; set; }
    }
}
