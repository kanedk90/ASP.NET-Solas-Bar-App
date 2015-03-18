using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPITest1.Controllers
{
    //Implement a Web API for the Review controller
    public class ReviewsController : ApiController
    {
        Solas1Db db = new Solas1Db();

        //api/get all
        public IEnumerable<SolasReview> GetAllReviews()
        {
            db.Configuration.ProxyCreationEnabled = false;
            var review = db.Reviews.ToList();
            return review;
        }

        //api/get/id
        public IHttpActionResult GetReviews(int id)        //the URL .. maps to this method
        {
            var reviews = db.Reviews.FirstOrDefault((p) => p.Id == id);
            if (reviews == null)
            {
                return NotFound();
            }
            return Ok(reviews);
        }

        //api/delete
        public IHttpActionResult DeleteReviews(int? id)
        {
            var reviews = db.Reviews.FirstOrDefault(n => n.Id == id);
            if (id == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            SolasReview review1 = reviews;
            db.Reviews.Remove(review1);
            db.SaveChanges();
            return Ok(reviews);
        }
        
        //api/post - had trouble posting through api and fiddler
        public IHttpActionResult PostReviews(SolasReview review)
        {
            var found = db.Reviews.FirstOrDefault(n => n.Id == review.Id);
            if (found == null)
            {
                db.Reviews.Add(review);
            }
            else
                found.Rating = review.Rating;
           
            return Ok(db);
        }
       
       
    }
}
