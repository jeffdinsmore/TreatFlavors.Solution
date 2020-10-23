using Microsoft.AspNetCore.Mvc;

namespace TreatFlavors.Controllers
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