using System;
using System.Collections.Generic;
using BloggerDotNet.Core.Interfaces;
using BloggerDotNet.Core.Objects;
using System.Data.SqlClient;
using Dapper;
using System.Threading.Tasks;
using System.Linq;

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

        public async Task<bool> DeletePost(string reference)
        {
            try
            {

                var query = "DELETE FROM" +
                                "dbo.Posts" +
                                "WHERE Reference = @Reference";
                await _dbConnection.ExecuteAsync(query, reference);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Post>> GetAllPublishedPosts()
        {
            try
            {
                var query = "SELECT [Reference],[MdContent],[DateCreated] FROM dbo.Posts WHERE [DateDeleted] IS NULL";

                var posts = await _dbConnection.QueryAsync<Post>(query).ConfigureAwait(false);
                return posts.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Post> GetPostByReference(string reference)
        {
            try
            {
                var query = "SELECT TOP 1" +
                                "[Reference],[MdContent],[DateCreated]" +
                                "FROM dbo.Posts" +
                                "WHERE Reference = @Reference";

                var posts = await _dbConnection.QueryFirstAsync<Post>(query, reference).ConfigureAwait(false);
                return posts;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Task<Post> UpdatePost(Post post)
        {
            throw new NotImplementedException();
        }
    }
}
