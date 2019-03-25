using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechniservApp.Models
{
    public class Sale
    {
        public int Id { get; set; }
        [Display(Name = "Zákazník")]
        public int PersonId { get; set; }
        [Display(Name = "Produkt")]
        public int ProductId { get; set; }
        [Display(Name = "Počet prodaných kusů")]
        public int ProductSoldUnits { get; set; }
        [Display(Name = "Celkem cena")]
        public int Total { get; set; }
        [Display(Name = "Datum prodeje")]
        public DateTime DateOfSale { get; set; }

        [ForeignKey(nameof(Sale.PersonId))]
        public virtual Person Person { get; set; }
        [ForeignKey(nameof(Sale.ProductId))]
        public virtual Product Product { get; set; }

    }
}