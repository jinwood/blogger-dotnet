using System;
using System.Collections.Generic;
using BloggerDotNet.Core.Interfaces;
using BloggerDotNet.Core.Objects;
using System.Data.SqlClient;
using Dapper;
using System.Threading.Tasks;

namespace BloggerDotNet.Data
{
    public class PostRepository : DbBase, IPostRepository
    {
        private SqlConnection _dbConnection;
        private SqlConnection DbConnection => _dbConnection ?? (_dbConnection = GetOpenConnection(true));

        public async Task<Post> CreatePost(Post post)
        {
            var result = await _dbConnection.QueryFirstAsync<Post>(
                "INSERT INTO dbo.Posts (Reference, HtmlContent, MdContent, DateCreated) VALUES(@Reference, @HtmlContent, @MdContent, @DateCreated)", 
                new {
                        Reference = post.Reference,
                        HtmlContent = post.HTMLContent,
                        MdContent = post.MdContent,
                        DateCreated = post.DateCreated
                    }).ConfigureAwait(false);
            return result;
        }

        public bool DeletePost(string reference)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPostByReference(string reference)
        {
            throw new NotImplementedException();
        }

        public Task<Post> UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }

        Task<bool> IPostRepository.DeletePost(string reference)
        {
            throw new NotImplementedException();
        }
    }
}
