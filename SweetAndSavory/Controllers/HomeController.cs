using Microsoft.AspNetCore.Mvc;
using System.Linq;
using SweetAndSavory.Models;
using SweetAndSavory.ViewModels;

namespace SweetAndSavory.Controllers
{
    public class HomeController : Controller
    {
    private readonly SweetAndSavoryContext _db;

    public HomeController(SweetAndSavoryContext db)
    {
      _db = db;
    }

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.PageTitle = "Pierre's Sweet and Savory Treats";
        var model = new IndexDisplayViewModel();
        model.Flavors = _db.Flavors.ToList();
        model.Treats = _db.Treats.ToList();
        return View(model);
      }
    }
}