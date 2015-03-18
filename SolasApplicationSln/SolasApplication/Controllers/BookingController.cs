using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolasApplication.Controllers
{
    public class BookingController : Controller
    {
        Solas1Db _db = new Solas1Db();
        
        //[Authorize] // - Implement for security puposes and over 18/21 users.
        [HttpGet]
        public ActionResult Booking(string Fname, string Sname, string Email)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Booking(Booking booking)
        {
            //Validate above Query to match with user Log in details.
            if (ModelState.IsValid)
            {
                //Add event to db and return confirmation
                _db.Event.Add(booking);
                _db.SaveChanges();
                return View("Confirmation");
                
            }
            else
                return View("Error");
        }
    }
}