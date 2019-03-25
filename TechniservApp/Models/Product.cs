using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechniservApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Název produktu")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Počet kusů na skladě")]
        public int Count { get; set; }
        [Required]
        [Display(Name = "Cena za kus")]
        public int PricePerUnit { get; set; }

        [InverseProperty(nameof(Sale.Product))]
        public ICollection<Sale> Sales { get; set; }
    }
}