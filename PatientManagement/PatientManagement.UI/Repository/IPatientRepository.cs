using PatientManagementSystem.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagement.Data.Repository
{
    public interface IPatientRepository
    {
        Task<IEnumerable<Patients>> GetAllPatientsAsync();  
        Task<Patients> GetPatientByIdAsync(int id);  
        Task<int> AddPatientAsync(Patients patient);  
        Task<int> UpdatePatientAsync(Patients patient);  
        Task<int> DeletePatientAsync(int id); 
    }
}
