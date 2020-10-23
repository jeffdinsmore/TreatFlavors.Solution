using Microsoft.AspNetCore.Mvc;
using TreatFlavors.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Diagnostics;
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