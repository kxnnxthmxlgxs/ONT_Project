using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PatientManagementSystem.Data.Models.Domain
{
    public class Patients
    {
        [Key]
        public int PatientId { get; set; }
       
        public string FirstName { get; set; }
       
        public string LastName { get; set; }

        public int AllergyId { get; set; }

        public int WardId { get; set; }

        public int ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }

    }
}
