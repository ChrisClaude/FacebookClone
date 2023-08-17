using Microsoft.EntityFrameworkCore;
using FacebookClone.Core.Entities;

namespace FacebookClone.Infrastructure.Data;

public class FacebookCloneDBContext : DbContext
{
    public FacebookCloneDBContext(DbContextOptions<FacebookCloneDBContext> options)
        : base(options)
    {
    }

    public DbSet<Comment> Comments { get; set; }
    public DbSet<CommentType> CommentTypes { get; set; }
    public DbSet<Content> Contents { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<LikeableType> LikeableTypes { get; set; }
    public DbSet<Like> Likes { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<ReactionType> ReactionTypes { get; set; }
    public DbSet<Video> Videos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Video>()
            .HasIndex(video => video.ContentId)
            .IsUnique();
    }
}
