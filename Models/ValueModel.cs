using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TICTAC.Models
{
    public class ValueModel
    {
        [Required]
        [Display(Name = "Enter a number")]        
        public int number { get; set; }
    }
}
