using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

// -- Note: Due to errors in Testing comment instructions were put in to show 
// -- logical process if testing was to work.
namespace SolasApplication.Controllers
{
    public class ReviewController : Controller
    {
        //Initiate SolasDb instance
        Solas1Db _db = new Solas1Db();
        // -- Alter for Testing - Uncomment out below for testing and comment out above
        //ISolas1Db _db;

        //Default constructor is to pass into the real SolasDb
        public ReviewController()
        {
            _db = new Solas1Db();
        }

        /*
         //Allows for mock db to pass in tests
         // -- Also had to comment out due to errors in testing
         public ReviewController(ISolas1Db db)
         {
             _db = db;
         }
        */

        // GET: Reviews
        public ActionResult Reviews()
        {
           var model = _db.Reviews.ToList();
            //--Change for testing - comment out above when testing and uncomment out below.
            //var model = _db.Query<SolasReview>();

            return View(model);
        }
        //Http get for creating review
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //Http post to display the reviews
        [HttpPost]
        public ActionResult Create(SolasReview review)
        {
            if (ModelState.IsValid)
            {
                //Comment out below 2 lines for testing
                _db.Reviews.Add(review);
                _db.SaveChanges();
                // -- Uncomment out below and comment out two lines above when testing
                //_db.Query<SolasReview>();
               
                return RedirectToAction("Reviews");
            }
            return View(review);
        }

        //Method to dispose a non null Solas db.
        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}