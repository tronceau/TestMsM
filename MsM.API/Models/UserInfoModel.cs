using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsM.API.Models
{
    public class UserInfoModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Givenname")]
        public string GivenName { get; set; }

        [Display(Name = "email")]
        public string Email { get; set; }

        [Display(Name = "Confirm email")]
        [Compare("Email", ErrorMessage = "Email and confirmation email do not match.")]
        public string ConfirmEmail { get; set; }
    }

}
