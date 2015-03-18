using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolasApplicationTests1.Features
{
    class TestData
    {
        //Create test class with 10 reviews with a rating of 6 for the mock Db to use
        public static IQueryable<SolasReview> Reviews
        {
            get
            {
               var reviews = new List<SolasReview>();
               for (int i = 1; i <10; i++)
               {
                   var review = new SolasReview();
                   review.Id = i;
                   review.Rating = 6;
                   reviews.Add(review);
               }
               return reviews.AsQueryable();
            }
            
        }
    }
}
