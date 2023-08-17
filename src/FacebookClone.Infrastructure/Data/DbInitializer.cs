using FacebookClone.Core.Entities;

namespace FacebookClone.Infrastructure.Data
{
    public static class DbInitializer
    {
        private const string DefaultCreatedBy = "Admin";

        public static async Task Initialize(FacebookCloneDBContext context)
        {
            if (!context.LikeableTypes.Any())
            {
                AddLikeableTypes(context);
            }

            if (!context.CommentTypes.Any())
            {
                AddCommentTypes(context);
            }

            if (context.ChangeTracker.HasChanges())
            {
                await context.SaveChangesAsync();
            }
        }

        private static void AddLikeableTypes(FacebookCloneDBContext context)
        {
            var likeableTypes = new List<LikeableType>
            {
                CreateLikeableType(nameof(Post)),
                CreateLikeableType(nameof(Comment))
            };

            context.AddRange(likeableTypes);
        }

        private static LikeableType CreateLikeableType(string typeValue)
        {
            return new LikeableType
            {
                LikeableTypeValue = typeValue,
                CreatedAt = DateTimeOffset.UtcNow,
                CreatedBy = DefaultCreatedBy
            };
        }

        private static void AddCommentTypes(FacebookCloneDBContext context)
        {
            var commentTypes = new List<CommentType>
            {
                CreateCommentType(nameof(Comment)),
                CreateCommentType("CommentReply")
            };

            context.AddRange(commentTypes);
        }

        private static CommentType CreateCommentType(string typeValue)
        {
            return new CommentType
            {
                CommentTypeValue = typeValue,
                CreatedAt = DateTimeOffset.UtcNow,
                CreatedBy = DefaultCreatedBy
            };
        }
    }
}
