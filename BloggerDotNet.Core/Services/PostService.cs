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
        private readonly IReferenceGenerator _referenceGenerator;
        private readonly IMarkdownProcessor _markdownProcessor;

        public PostService(IPostRepository postRepository, IReferenceGenerator referenceGenerator, IMarkdownProcessor markdownProcessor)
        {
            _postRepository = postRepository ?? throw new ArgumentNullException();
            _referenceGenerator = referenceGenerator ?? throw new ArgumentNullException();
            _markdownProcessor = markdownProcessor ?? throw new ArgumentNullException();
        }

        public Task<Post> CreatePost(Post post)
        {
            post = post ?? throw new ArgumentNullException();

            post.DateCreated = DateTime.UtcNow;
            post.Reference = _referenceGenerator.CreateReference(Constants.CryptographicReferenceLength);

            return _postRepository.CreatePost(post);
        }

        public Task<List<bool>> DeletePost(string reference)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Post>> GetAllPosts()
        {
            var posts = await _postRepository.GetAllPublishedPosts();

            if(posts == null) return null;

            foreach(var post in posts)
            {
                post.HTMLContent = _markdownProcessor.ConvertToHTML(post.MdContent);
            }
            return posts;            
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
