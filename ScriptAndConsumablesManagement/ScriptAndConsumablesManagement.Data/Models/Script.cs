using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptAndConsumablesManagement.Data.Models
{
    public class Script
    {
        [Key]
        public int ScriptID { get; set; }
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
        public int PatientFileID { get; set; }
        public PatientFile PatientFile { get; set; }
        public int MedicationID { get; set; }
        public Medication Medication { get; set; }
        public string Date { get; set; }
        public char Status { get; set; }
        public int Dosage { get; set; }
    }
}
