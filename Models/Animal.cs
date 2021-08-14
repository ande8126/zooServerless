using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace new_zoo_app.Models
{
    public class Animal 
    //building out model for each animal added to zoo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Display(Name = "Species name")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} is needed")]
        public string species { get; set; }
        [Display(Name = "Age")]
        [Required(ErrorMessage = "{0} is needed")]
        public int age { get; set; }
        [Display(Name = "Species")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} is needed")]   
        public string gender { get; set; }
        [Display(Name = "Animal name")]
        [StringLength(20)]
        [Required(ErrorMessage = "{0} is needed")] 
        public string name { get; set; }
        [Display(Name = "Exhibit")]
        public int exhibits_id { get; set; }
    }
}