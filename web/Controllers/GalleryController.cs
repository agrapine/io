using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Web.Data.Cronic;

namespace Web.Controllers
{
  [Route("api/[controller]")]
  public class GalleryController : Controller
  {

    private CronicData data;

    public GalleryController(CronicData data)
    {
      this.data = data;
    }


    [HttpGet("[action]")]
    public IEnumerable<Photo> Photos()
    {
      return data.Set<Photo>();
    }
  }
}
