using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlogLab.models.Account
{
    public class ApplicationUserLogin
    {
        [Required(ErrorMessage = "Username is required")]
        [MinLength(5, ErrorMessage ="Must be at least 5 - 20 characters")]
        [MaxLength(20, ErrorMessage ="Must be at least 5 - 20 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(10, ErrorMessage = "Must be at least 10 - 20 characters")]
        [MaxLength(20, ErrorMessage = "Must be at least 10 - 20 characters")]
        public string Password { get; set; }

    }
}
