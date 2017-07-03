using BloggerDotNet.Core.Objects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BloggerDotNet.Core.Interfaces
{
    public interface IPostRepository
    {
        Task<List<Post>> GetAllPosts();
        Task<Post> GetPostByReference(string reference);
        Task<Post> CreatePost(Post post);
        Task<bool> DeletePost(string reference);
        Task<Post> UpdatePost(Post post);
    }
}
