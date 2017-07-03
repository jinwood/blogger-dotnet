using BloggerDotNet.Core.Objects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BloggerDotNet.Core.Interfaces
{
    public interface IPostService
    {
        Task<List<Post>> GetAllPosts();
        Task<List<Post>> GetPostByReference(string reference);
        Task<Post> CreatePost(Post post);
        Task<List<bool>> DeletePost(string reference);
        Task<List<Post>> UpdatePost(Post post);
    }
}
