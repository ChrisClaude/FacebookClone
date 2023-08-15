using System.ComponentModel.DataAnnotations;

namespace FacebookClone.Core.Entities;

public class Video : EntityBase
{
    // TODO: Make sure this ContentId is unique in the table
    public int ContentId { get; set; }

    [Required(ErrorMessage = "The field is required.")]
    public string VideoURL { get; set; }

    [Required(ErrorMessage = "The field is required.")]
    public string ThumbnailURL { get; set; }
}
