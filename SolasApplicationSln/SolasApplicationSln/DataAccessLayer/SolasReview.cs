using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
     public class SolasReview
     {
         //Solas Review without requirements based on api format
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public ICollection<SolasReview> Reviews { get; set; }

    }
}
