using System.Collections.Generic;
using SweetAndSavory.Models;

namespace SweetAndSavory.ViewModels
{
  public class IndexDisplayViewModel
  {
    public IEnumerable<Flavor> Flavors { get; set; }
    public IEnumerable<Treat> Treats {get; set; }
  }
}