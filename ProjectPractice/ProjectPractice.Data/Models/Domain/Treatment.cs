using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractice.Data.Models.Domain
{
    public class Treatment
    {
        [Key]
        public int TreatmentID { get; set; }
        public string TreatmentName { get; set; }
    }
}
