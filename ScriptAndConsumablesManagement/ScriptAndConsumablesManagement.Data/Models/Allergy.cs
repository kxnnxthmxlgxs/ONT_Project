using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractice.Data.Models.Domain
{
    public class Allergy
    {
        [Key]
        public int AllergyID { get; set; }
        public string AllergyName { get; set; }
    }
}
