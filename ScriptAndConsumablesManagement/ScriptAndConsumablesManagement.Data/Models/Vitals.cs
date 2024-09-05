using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractice.Data.Models.Domain
{
    public class Vitals
    {
        [Key]
        public int VitalID { get; set; }
        public int VitalName { get; set; }
    }
}
