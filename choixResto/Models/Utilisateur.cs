﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace choixResto.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        [Required]
        public string Prenom { get; set; }
        public string MotDePasse { get; set; }
    }
}