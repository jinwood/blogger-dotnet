using BloggerDotNet.Core.Objects;
using System.Collections.Generic;

namespace BloggerDotNet.Core.Interfaces
{
    public interface IPostService
    {
        List<Post> GetAllPosts();
        Post GetPostByReference(string reference);
        Post CreatePost(Post post);
        bool DeletePost(string reference);
        Post UpdatePost(Post post);
    }
}
