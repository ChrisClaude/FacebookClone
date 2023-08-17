using System.ComponentModel.DataAnnotations;

namespace FacebookClone.Core.Entities;

public class Video : EntityBase
{
    public int ContentId { get; set; }

    [Required(ErrorMessage = "The field is required.")]
    public string VideoURL { get; set; }

    [Required(ErrorMessage = "The field is required.")]
    public string ThumbnailURL { get; set; }
}
