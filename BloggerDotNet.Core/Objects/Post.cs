using System;

namespace BloggerDotNet.Core.Objects
{
    public class Post
    {
        public int PostId { get; set; }
        public string Reference { get; }

        public DateTime DateCreated { get; }

        public Post(DateTime dateCreated) //pass in a reference generator
        {
            DateCreated = dateCreated;
            Reference = string.Empty; //generate the reference
        }
    }
}
