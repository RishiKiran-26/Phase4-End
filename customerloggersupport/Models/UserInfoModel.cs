using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace customerloggersupport.Models
{
    public class UserInfoModel
    {
        public int UserId { get; set; }


        [Display(Name = "Email:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Passowrd:")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Minimum 6 characters required")]
        public string Password { get; set; }
    }
}