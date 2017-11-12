using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Io.Data;
using System.Linq;

namespace Io.Controllers
{
  [Route("api/[controller]")]
  public class GalleryController : Controller
  {

    private IoDb db;

    public GalleryController(IoDb data)
    {
      this.db = data;
    }


    [HttpGet("[action]")]
    public IEnumerable<Photo> Photos()
    {
      var photos = db.Set<Photo>().ToList();
      return photos;
    }
  }
}
