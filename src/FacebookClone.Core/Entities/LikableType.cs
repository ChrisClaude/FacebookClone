using System.ComponentModel.DataAnnotations;

namespace FacebookClone.Core.Entities;

public class LikeableType : EntityBase
{
    [Required(ErrorMessage = "The field is required.")]
    [MinLength(3, ErrorMessage = "The field must be a minimum length of 3.")]
    [RegularExpression(@"^[\S\s]*\S[\S\s]*$", ErrorMessage = "The field cannot be empty or contain only whitespace.")]
    public string LikeableTypeValue { get; set; }
}
