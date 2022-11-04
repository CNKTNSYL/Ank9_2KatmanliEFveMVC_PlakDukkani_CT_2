using Ank9_EF_Entities_CT.Data;
using Ank9_MvcUI_PlakDukkani_CT.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Ank9_MvcUI_PlakDukkani_CT.Controllers
{
    public class RecordController : Controller
    {
        private RecordStoreDbContext _db;

        public RecordController(RecordStoreDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.cnk = _db.Bands.ToList();
            var c = _db.Musicians.Include(x => x.Band).ToList();
            return View(c);
        }

        [HttpGet]
        public IActionResult CreateBand()
        {
            return View(new NewBand());
        }

        [HttpPost]
        public IActionResult CreateBand(NewBand nb)
        {
            if (ModelState.IsValid)
            {
                _db.Bands.Add(nb.GetBand());
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(nb);
            }
        }

        [HttpGet]
        public IActionResult CreateMusician()
        {
            ViewBag.cnk = new SelectList(_db.Bands.ToList(),"Id","Name");
            return View(new NewMusician());
        }

        [HttpPost]
        public IActionResult CreateMusician(NewMusician nm)
        {
            if (ModelState.IsValid)
            {
                _db.Musicians.Add(nm.GetMusician());
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(nm);
            }
        }
    }
}
