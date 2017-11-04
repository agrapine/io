using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Data.Cronic
{
  [Table("Photo")]
  public class Photo
  {
    [Key]
    public Guid Id { get; set; }

    [Column]
    public string Title { get; set; }

    [Column]
    public string Description { get; set; }

    [Column]
    public string ThumbUrl { get; set; }

    [Column]
    public string ImageUrl { get; set; }
  }
}
