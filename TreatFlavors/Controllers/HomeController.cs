using Microsoft.AspNetCore.Mvc;
using TreatFlavors.Models;
using System.Collections.Generic;
using System.Linq;

namespace TreatFlavors.Controllers
{
  public class HomeController : Controller
  {
    private readonly TreatFlavorsContext _db;
    public HomeController(TreatFlavorsContext db)
    {
      _db = db;
    }
    public IActionResult Index()
    {
      List<Flavor> modelFlavor = _db.Flavors.OrderBy(o => o.FlavorName).ToList();
      List<Treat> modelTreat = _db.Treats.OrderBy(o => o.TreatName).ToList();
      ViewBag.Treat = modelTreat;
      ViewBag.Flavor = modelFlavor;
      return View();
    }
  }
}