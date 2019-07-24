using System;
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
        //test github
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        public string Telephone { get; set; }
    }
}