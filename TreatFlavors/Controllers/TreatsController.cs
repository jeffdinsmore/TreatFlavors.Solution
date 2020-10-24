using Microsoft.AspNetCore.Mvc;
using TreatFlavors.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Linq;

namespace TreatFlavors.Controllers
{
  public class TreatsController : Controller
  {
    private readonly TreatFlavorsContext _db;

    public TreatsController(TreatFlavorsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.OrderBy(o => o.TreatName).ToList();
      return View(model);
    }

    [Authorize(Roles = "Administrator")]
    public ActionResult Create()
    {
      return View();
    }

    [Authorize(Roles = "Administrator")]
    [HttpPost]
    public ActionResult Create(Treat treat)
    {
      _db.Treats.Add(treat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    [Authorize]
    public ActionResult Details(int id)
    {
      var thisTreat = _db.Treats
        .Include(treat => treat.FlavorTreats)
        .ThenInclude(join => join.Flavor)
        .FirstOrDefault(treat => treat.TreatId == id);
      return View(thisTreat);
    }

    [Authorize(Roles = "Administrator")]
    public ActionResult Edit(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "FlavorName");
      return View(thisTreat);
    }

    [Authorize(Roles = "Administrator")]
    [HttpPost]
    public ActionResult Edit(Treat treat)
    {
      _db.Entry(treat).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = treat.TreatId });
    }

    [Authorize(Roles = "Administrator")]
    public ActionResult Delete(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
      return View(thisTreat);
    }

    [Authorize(Roles = "Administrator")]
    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
      _db.Treats.Remove(thisTreat);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [Authorize(Roles = "Administrator")]
    [HttpPost]
    public ActionResult DeleteFlavor(int flavorTreatId, int treatId)
    {
      var flavorTreat = _db.FlavorTreats.FirstOrDefault(entry => entry.FlavorTreatId == flavorTreatId);
      _db.FlavorTreats.Remove(flavorTreat);
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = treatId });
    }

    [Authorize(Roles = "Administrator")]
    public ActionResult AddFlavor(int id)
    {
      var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
      ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "FlavorName");
      return View(thisTreat);
    }

    [Authorize(Roles = "Administrator")]
    [HttpPost]
    public ActionResult AddFlavor(Treat treat, int FlavorId)
    {
      if (FlavorId != 0)
      {
        _db.FlavorTreats.Add(new FlavorTreat() { FlavorId = FlavorId, TreatId = treat.TreatId });
      }
      _db.SaveChanges();
      return RedirectToAction("Details", new { id = treat.TreatId });
    }

    public ActionResult Search()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Search(string treatName)
    {
      List<Treat> model = _db.Treats.Include(x => x.FlavorTreats).Where(x => x.TreatName.Contains(treatName)).ToList();
      List<Treat> SortedList = model.OrderBy(o => o.TreatName).ToList();
      return View("Index", SortedList);
    }
  }
}