﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace choixResto.Models
{
    [Table("Restos")]
    public class Resto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Le nom du restaurant doit être saisi")]
        public string Nom { get; set; }
        [Display(Name = "Téléphone")]
        [RegularExpression(@"^0[0-9]{9}$", ErrorMessage = "Le numéro de téléphone est incorrect")]
        public string Telephone { get; set; }
    }
}