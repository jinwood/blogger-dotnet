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

        public PostRepository()
        {
            _dbConnection = GetOpenConnection(true);
        }

        public async Task<Post> CreatePost(Post post)
        {
            try
            {
                var query = "INSERT INTO " +
                                "dbo.Posts (Reference, HtmlContent, MdContent, DateCreated) " +
                                "VALUES(@Reference, @HtmlContent, @MdContent, @DateCreated) " +
                                "SELECT * FROM dbo.Posts WHERE Reference = @Reference";
                var result = await _dbConnection.QueryFirstAsync<Post>(
                    query,
                    new
                    {
                        Reference = post.Reference,
                        HtmlContent = post.HTMLContent,
                        MdContent = post.MdContent,
                        DateCreated = post.DateCreated
                    });
                return result;
            }
            catch (Exception)
            {
                return null;
            }
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
