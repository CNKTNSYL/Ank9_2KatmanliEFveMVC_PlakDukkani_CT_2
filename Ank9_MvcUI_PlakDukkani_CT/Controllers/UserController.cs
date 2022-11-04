using Microsoft.AspNetCore.Mvc;
using Ank9_MvcUI_PlakDukkani_CT.ViewModels;
using Ank9_EF_Entities_CT.Data;
using Ank9_EF_Entities_CT.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ank9_MvcUI_PlakDukkani_CT.Controllers
{
    public class UserController : Controller
    {
        private RecordStoreDbContext _db;

        public UserController(RecordStoreDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            //ViewBag.cnk = new SelectList(_db.Users.ToList(), "Id", "Name");
            return View();
        }

        [HttpGet]
        public IActionResult CreateNewUser()
        {
            return View(new NewUser());
        }

        [HttpPost]
        public IActionResult CreateNewUser(NewUser user)
        {
            if (ModelState.IsValid)
            {
                //User Kaydet
                _db.Users.Add(user.GetUser());
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(user);
            }
        }
    }
}
