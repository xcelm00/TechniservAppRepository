using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechniservApp.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Stát")]
        public string State { get; set; }
        [Required]
        [Display(Name = "Město")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Ulice")]
        public string Street { get; set; }
        [Required]
        [Display(Name = "Číslo popisné")]
        public int StreetNumber { get; set; }
        [Required]
        [Display(Name = "PSČ")]
        public int PoBox { get; set; }
        [Display(Name = "Zákazník")]
        public string CommonName { get; set; }

        [InverseProperty(nameof(Sale.Person))]
        public ICollection<Sale> Sales { get; set; }
    }
}