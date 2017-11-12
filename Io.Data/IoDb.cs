using Microsoft.EntityFrameworkCore;
using System;

namespace Io.Data
{
  public class IoDb : DbContext
  {
    public IoDb(DbContextOptions<IoDb> options)
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
