using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Web.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Column(TypeName = "NVARCHAR(450)")]
        
        public string Picture { get; set; }
        [Column(TypeName = "NVARCHAR(15)")]
        public string Gender { get; set; }

        public DateTime DOB { get; set; }
    }
}
