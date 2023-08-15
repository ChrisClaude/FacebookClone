using System.ComponentModel.DataAnnotations;

namespace FacebookClone.Core.Entities;

public class Comment : EntityBase
{
    [Required(ErrorMessage = "The field is required.")]
    [MinLength(3, ErrorMessage = "The field must be a minimum length of 3.")]
    [RegularExpression(@"^[\S\s]*\S[\S\s]*$", ErrorMessage = "The field cannot be empty or contain only whitespace.")]
    public string UserId { get; set; }

    // This could be a PostId or a CommentId
    public int CommentableId { get; set; }

    public int CommentableTypeId { get; set; }
    [Required(ErrorMessage = "The field is required.")]
    [MinLength(1, ErrorMessage = "The field must be a minimum length of 1.")]
    [RegularExpression(@"^[\S\s]*\S[\S\s]*$", ErrorMessage = "The field cannot be empty or contain only whitespace.")]
    public string Text { get; set; }
}
