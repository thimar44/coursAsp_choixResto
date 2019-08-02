using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace choixResto.ViewModels
{
    public class RestaurantVoteViewModel
    {
        public List<RestaurantCheckBoxViewModel> ListeDesResto { get; set; }

        /*public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // à faire !
        }*/
    }
}