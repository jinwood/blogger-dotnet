using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BloggerDotNet.Core.Interfaces;
using BloggerDotNet.Core.Objects;

namespace BloggerDotNet.Core.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository ?? throw new ArgumentNullException();
        }

        public Task<Post> CreatePost(Post post)
        {
            post = post ?? throw new ArgumentNullException();

            return _postRepository.CreatePost(post);
        }

        public Task<List<bool>> DeletePost(string reference)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> GetPostByReference(string reference)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
