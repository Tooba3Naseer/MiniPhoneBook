using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Contacts
    {

        [Required(ErrorMessage = "Please enter contact")]
        public int ContactNumber { get; set; }




        [Required]
        public string Type { get; set; }
    }
}