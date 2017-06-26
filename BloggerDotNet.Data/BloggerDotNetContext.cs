using BloggerDotNet.Core.Objects;
using BloggerDotNet.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BloggerDotNet.Data
{
    public class BloggerDotNetContext : DbContext, IBloggerDotNetContext
    {
        public virtual DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<Post>().Property(v => v.Reference)
            //    .HasMaxLength(25)
            //    .IsRequired(true);
            //builder.Entity<Post>().HasIndex(v => v.PostId);
            //builder.Entity<Post>().HasIndex(v => v.Reference);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=Gloodoo.Directory;Integrated Security=True;MultipleActiveResultSets=True");
        }
    }
}
