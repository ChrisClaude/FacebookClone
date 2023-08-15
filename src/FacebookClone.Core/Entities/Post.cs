using System.ComponentModel.DataAnnotations;

namespace FacebookClone.Core.Entities;

public class Post : EntityBase
{
    [Required(ErrorMessage = "The field is required.")]
    [MinLength(3, ErrorMessage = "The field must be a minimum length of 3.")]
    [RegularExpression(@"^[\S\s]*\S[\S\s]*$", ErrorMessage = "The field cannot be empty or contain only whitespace.")]
    public string UserId { get; set; }
    public int ContentId { get; set; }
    public int VisibilityId { get; set; }
    public string Location { get; set; }

    public Content Content { get; set; }
}
