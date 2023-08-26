using FacebookClone.Core.Entities;
using FacebookClone.SharedKernel;

namespace FacebookClone.Infrastructure.Data
{
    public static class SeedData
    {
        private const string DefaultCreatedBy = "Admin";

        public static List<LikeableType> GetLikeableTypes()
        {
            return new List<LikeableType>
            {
                CreateLikeableType(nameof(Post), 1),
                CreateLikeableType(nameof(Comment), 2)
            };
        }

        private static LikeableType CreateLikeableType(string typeValue, int id)
        {
            return new LikeableType
            {
                Id = id,
                LikeableTypeValue = typeValue,
                CreatedAt = DateTimeOffset.UtcNow,
                CreatedBy = DefaultCreatedBy
            };
        }

        public static List<CommentType> GetCommentTypes()
        {
            return new List<CommentType>
            {
                CreateCommentType(nameof(Comment), 1),
                CreateCommentType("CommentReply", 2)
            };
        }

        private static CommentType CreateCommentType(string typeValue, int id)
        {
            return new CommentType
            {
                Id = id,
                CommentTypeValue = typeValue,
                CreatedAt = DateTimeOffset.UtcNow,
                CreatedBy = DefaultCreatedBy
            };
        }

        public static List<ReactionType> GetReactionTypes()
        {
            return new List<ReactionType>
            {
                CreateReactionType(ReactionTypes.Like.ToString(), 1),
                CreateReactionType(ReactionTypes.Love.ToString(), 2),
                CreateReactionType(ReactionTypes.Care.ToString(), 3),
                CreateReactionType(ReactionTypes.Laugh.ToString(), 4),
                CreateReactionType(ReactionTypes.Wow.ToString(), 5),
                CreateReactionType(ReactionTypes.Sad.ToString(), 6),
                CreateReactionType(ReactionTypes.Angry.ToString(), 7)
            };
        }

        private static ReactionType CreateReactionType(string typeValue, int id)
        {
            return new ReactionType
            {
                Id = id,
                ReactionTypeValue = typeValue,
                CreatedAt = DateTimeOffset.UtcNow,
                CreatedBy = DefaultCreatedBy
            };
        }
    }
}
