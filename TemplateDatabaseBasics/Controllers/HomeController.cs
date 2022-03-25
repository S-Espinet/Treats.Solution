using Microsoft.AspNetCore.Mvc;

namespace TemplateDatabaseBasics.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}