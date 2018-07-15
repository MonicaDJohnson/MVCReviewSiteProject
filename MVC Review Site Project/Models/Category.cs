using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Review_Site_Project.Models
{
    public class Category 
    {
        [Key]
        public int CategoryID { get; set; }
        public string BrandName { get; set; }//I created my controllers before I fixed my spacing, which is why it is showing up on the site like this. I don't want to make any changes here because I don't want to alter any other code.
        public double Price { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }


        
    }
}