using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Booking
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter the First name that matches your ID")]
        [StringLength(30, MinimumLength = 1)]
        [Display(Name = "First Name")]
        public string Fname { get; set; }

        [Required(ErrorMessage = "You must enter the Last name that matches your ID")]
        [StringLength(30, MinimumLength = 1)]
        [Display(Name = "Last Name")]
        public string Sname { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "invalid Email")]
        public string Email { get; set; }

        [Range(21, 120)]
        public int Age { get; set; }

        [Range(8, 180)]
        public int PartySize { get; set; }

        [StringLength(180, MinimumLength = 0)]
        public string Message { get; set; }
        //public ICollection<Events> Event { get; set; }

    }
}
