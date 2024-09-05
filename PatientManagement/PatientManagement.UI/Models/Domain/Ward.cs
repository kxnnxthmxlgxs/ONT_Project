using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PatientManagementSystem.Data.Models.Domain
{
    public class Ward
    {
        [Key]
        public int WardID { get; set; }
        [Required]
        public string WardName { get; set; }
        public string
    }
}
