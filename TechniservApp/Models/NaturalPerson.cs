using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechniservApp.Models
{
    [Table("NaturalPersons")]
    public class NaturalPerson : Person
    {
        [Required]
        [Display(Name = "Jméno")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Příjmení")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Rodné číslo")]

        public int RC { get; set; }
    }
}