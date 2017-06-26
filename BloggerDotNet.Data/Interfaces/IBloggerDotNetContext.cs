using BloggerDotNet.Core.Objects;
using Microsoft.EntityFrameworkCore;

namespace BloggerDotNet.Data.Interfaces
{
    public interface IBloggerDotNetContext
    {
        DbSet<Post> Posts { get; set; }

        int SaveChanges();
    }
}
