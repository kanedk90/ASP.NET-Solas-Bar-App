using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolasApplication.Controllers;
using NUnit.Framework;
using DataAccessLayer;
namespace SolasApplication.Controllers.Tests
{
    [TestFixture()]
    public class ReviewControllerTests
    {
        //Create test to test that reviews only allow value up to the number 10
        [Test()]
        public void ReviewsTest()
        {
            SolasDb4 target = new SolasDb4("Larry", 5);
            int score = 11;
            target.Reviews(score);

  
        }

        [Test()]
        public void CreateTest()
        {
            SolasDb4 target = new SolasDb4("Larry", 5);
            int score = 11;
            target.Reviews(score);
            Assert.Fail();
        }
    }
}
