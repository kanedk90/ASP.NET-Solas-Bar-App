using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolasApplication.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer;
using SolasApplicationTests1.Mocks;
using SolasApplicationTests1.Features;
using SolasApplicationTests1.Controllers;

namespace SolasApplication.Controllers.Tests
{
    [TestClass()]
    public class ReviewControllerTests
    {
        [TestMethod()]
        public void CreateReviewTest()
        {
            //Use mock Db and test class to evaluate unit test
            var db = new MockSolasDb4();
            db.AddSet(TestData.Reviews);
            
            //create instance and pass in an args to determine mock class
            // -- Cant understand why this didn't work
            ReviewController controller = new ReviewController(db);

            ViewResult result = controller.Reviews() as ViewResult;

          
            //Assert that 6 is expected and is the same as what is added.
            Assert.AreEqual(6,db.Added.Count);
            //Assert that the input has been saved
            Assert.AreEqual(true, db.Saved);
        }
    }
}
