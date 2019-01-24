using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DragonFormsVsModelBinding.Models
{
    public class Dragon
    {
        [Key]
        public int DragonID { get; set; }


        public Species SpeciesID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
