using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
     public class SolasReview
     {
         //Create Review page with requirements for inputs.
        public int Id { get; set; }
        
        [Range (1,10)]
        [Required(ErrorMessage ="Please enter a rating from 1-10")]

        public int Rating { get; set; }
        [Required(ErrorMessage = "Please enter your Name")]

        public string Name { get; set; }
        [Required(ErrorMessage= "Please add a comment")]

        public string Body { get; set; }

        public ICollection<SolasReview> Reviews { get; set; }
    }
}
