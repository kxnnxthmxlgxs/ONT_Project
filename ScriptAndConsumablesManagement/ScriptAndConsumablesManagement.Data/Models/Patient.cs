﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptAndConsumablesManagement.Data.Models
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        public int AllergyID { get; set; } // TODO: Nav prop later
        public int WardID { get; set; } // TODO: Nav prop later
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string? Address2 { get; set; }

    }
}
