using System.ComponentModel.DataAnnotations;

namespace FacebookClone.Core.Entities;

public class Like : EntityBase
{
    [Required(ErrorMessage = "The field is required.")]
    [MinLength(3, ErrorMessage = "The field must be a minimum length of 3.")]
    [RegularExpression(@"^[\S\s]*\S[\S\s]*$", ErrorMessage = "The field cannot be empty or contain only whitespace.")]
    public string UserId { get; set; }

    // The LikableId refers to the Id of a post or a comment
    public int LikableId { get; set; }

    public int LikeableTypeId { get; set; }

    public int ReactionTypeId { get; set; }
}
