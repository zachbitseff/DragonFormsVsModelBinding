using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DragonFormsVsModelBinding.Models
{
    public class Class
    {

        [Key]
        public int ClassID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
