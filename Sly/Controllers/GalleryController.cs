using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Sly.Controllers
{
  [Route("api/[controller]")]
  public class GalleryController : Controller
  {
    private static Photo[] _photos =
      new Photo[]
      {
        new Photo
        {
          Title = "across",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/across.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/across.jpg",
        },
        new Photo
        {
          Title = "a moment",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/a-moment.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/a-moment.jpg",
        },
        new Photo
        {
          Title = "at ease",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/at-ease.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/at-ease.jpg",
        },
        new Photo
        {
          Title = "bottled up",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/bottled-up.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/bottled-up.jpg",
        },
        new Photo
        {
          Title = "burning man",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/burning-man.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/burning-man.jpg",
        },
        new Photo
        {
          Title = "endless",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/endless.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/endless.jpg",
        },
        new Photo
        {
          Title = "grab",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/grab.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/grab.jpg",
        },
        new Photo
        {
          Title = "grown",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/grown.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/grown.jpg",
        },
        new Photo
        {
          Title = "hrrr",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/hrrr.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/hrrr.jpg",
        },
        new Photo
        {
          Title = "i can see it",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/i-can-see-it.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/i-can-see-it.jpg",
        },
        new Photo
        {
          Title = "i m not that bright",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/i-m-not-that-bright.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/i-m-not-that-bright.jpg",
        },
        new Photo
        {
          Title = "kings cross",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/kings-cross.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/kings-cross.jpg",
        },
        new Photo
        {
          Title = "krisu",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/krisu.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/krisu.jpg",
        },
        new Photo
        {
          Title = "reveal",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/reveal.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/reveal.jpg",
        },
        new Photo
        {
          Title = "reverb",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/reverb.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/reverb.jpg",
        },
        new Photo
        {
          Title = "shallow waters",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/shallow-waters.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/shallow-waters.jpg",
        },
        new Photo
        {
          Title = "shining through",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/shining-through.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/shining-through.jpg",
        },
        new Photo
        {
          Title = "ssss",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/ssss.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/ssss.jpg",
        },
        new Photo
        {
          Title = "union",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/union.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/union.jpg",
        },
        new Photo
        {
          Title = "usirk",
          Description = "...",
          ThumbUrl = "https://slyngallery.blob.core.windows.net/gallery/thumbs/usirk.jpg",
          ImageUrl = "https://slyngallery.blob.core.windows.net/gallery/usirk.jpg",
        }
      };

    [HttpGet("[action]")]
    public IEnumerable<Photo> Photos()
    {
      return _photos;
    }

    public class Photo
    {
      public string Title { get; set; }
      public string Description { get; set; }
      public string ThumbUrl { get; set; }
      public string ImageUrl { get; set; }
    }
  }
}
