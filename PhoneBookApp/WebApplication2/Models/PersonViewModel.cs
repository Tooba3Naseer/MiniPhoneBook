using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    // it will contain all data members of person table
    public class PersonViewModel
    {
        [Required(ErrorMessage = "Please enter name")]
        public string FirstName { get; set; }

        
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter date of birth")]
        public DateTime DOB { get; set; }

        [Required]
        public DateTime AddedOn { get; set; }

        [Required]
        public string AddedBy { get; set; }

        [Required]
        public string HomeAddress { get; set; }

        [Required]
        public string HomeCity { get; set; }

        
        public string FacebookId { get; set; }

        public string LinkedInId { get; set; }

        public DateTime UpdateOn { get; set; }

        public string TwitterId { get; set; }

        



        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
        ErrorMessage = "Please enter a valid email address")]
        public string EmailId { get; set; }

       
    }
}