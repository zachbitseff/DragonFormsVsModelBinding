using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DragonFormsVsModelBinding.Models
{
    public class Species
    {
        [Key]
        public int SpeciesID { get; set; }


        public string Name { get; set; }

        public string Description { get; set; }

        public Class ClassID { get; set; }


        public int TalonsPerClaw { get; set; }

        public int NumberOfHeads { get; set; }

        public int NumberOfTails { get; set; }
    }
}
