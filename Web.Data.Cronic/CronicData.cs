using Microsoft.EntityFrameworkCore;
using System;

namespace Web.Data.Cronic
{
  public class CronicData : DbContext
  {
    public CronicData(DbContextOptions<CronicData> options)
      : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder model)
    {
      base.OnModelCreating(model);
      model.Entity<Photo>();
    }
  }
}
