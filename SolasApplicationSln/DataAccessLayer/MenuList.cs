using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /*Create List of MenuList to create Primary key and product info
   ===============================================================*/
    public class MenuList
    {
        //No requirements on Menu as it is just a page to be viewed
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cocktail { get; set; }
        public string Beer { get; set; }
        public string Liquor { get; set; }
       // public ICollection<MenuList> Menu { get; set; }
    }
}
