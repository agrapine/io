using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Io.Config
{
  public class AppConfig
  {
    [JsonProperty("connectionStrings")]
    public ConnectionStrings ConnectionStrings { get; set; }
  }

  public class ConnectionStrings
  {
    [JsonProperty("iodb")]
    public string IoDb { get; set; }
  }
}
