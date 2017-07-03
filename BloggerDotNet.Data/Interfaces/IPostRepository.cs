using BloggerDotNet.Core.Objects;
using System.Collections.Generic;

namespace BloggerDotNet.Data.Interfaces
{
    public interface IPostRepository
    {
        Post CreatePost(Post post);
        Post GetPost(int id);
        List<Post> GetAllPosts();
    }
}
