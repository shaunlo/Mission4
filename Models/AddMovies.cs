using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//For the Rating field, use a dropdown menu (G, PG, PG-13, R).
// For the Edited field, we want that to be a yes/no (true/false) option.
// The “Edited”, “Lent To”, and “Notes” fields are optional. All other fields must be
//entered.
//Notes should be limited to 25 characters.

namespace Mission4.Models
{
    public class AddMovies
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required (ErrorMessage = "Material cost is required")]
        public string MovieName { get; set; }

        [Required (ErrorMessage = "Material cost is required")]
        public string Rating { get; set; }

        public string Edit { get; set; }

        public string LentTo { get; set; }

        [StringLength(25)]
        public string Notes { get; set; }


    }
}
