using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolasApplication.Controllers
{
    public class MenuController : Controller
    {
        //Standard Menu Db controller
        Solas1Db _db = new Solas1Db();
        // GET: Menu
        public ActionResult Menu()
        {
            var model = _db.Menu.ToList();
            return View(model);
        }
    }
}