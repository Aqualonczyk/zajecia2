using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace zajecia2.Models
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica")]
        [StringLength(60, MinimumLength =3), Required(ErrorMessage ="Pole jest obowiązkowe")]
        public string Street { get; set; }
        [Display(Name = "ZipCode")]
        public string ZipCode { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "Number")]
        public string Number { get; set; }
    }
}
