﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptAndConsumablesManagement.Data.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Email {  get; set; }
        public string Address1 { get; set; }
        public string? Address2 { get; set; }
    }
}
