using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechniservApp.Models
{
    [Table("LegalPersons")]
    public class LegalPerson : Person
    {
        [Required]
        [Display(Name = "Jméno")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "IČO")]
        public int ICO { get; set; }

    }
}