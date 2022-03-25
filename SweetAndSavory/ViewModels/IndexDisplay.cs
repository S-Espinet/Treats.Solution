using System.Collections.Generic;

namespace SweetAndSavory.Models
{
  public class IndexDisplay
  {
    public IEnumerable<Flavor> Flavors { get; set; }
    public IEnumerable<Treat> Treats {get; set; }
  }
}