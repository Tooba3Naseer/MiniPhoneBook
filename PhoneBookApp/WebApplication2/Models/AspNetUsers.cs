using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class AspNetUsers
    {
        // it will contain data members of aspnetuser table
        [Required(ErrorMessage = "Please enter name")]
        public string UserName { get; set; }


       

        [Required]
        public int TwoFactorEnabled { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public int PhoneNumberConfirmed { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
        ErrorMessage = "Please enter a valid email address")]
        public string EmailConfirmed { get; set; }





        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
        ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

    }
}