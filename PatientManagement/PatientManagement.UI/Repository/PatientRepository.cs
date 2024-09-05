using PatientManagement.Data.DataAccess;
using PatientManagement.Data.Repository;
using PatientManagementSystem.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientManagementSystem.Data.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ISqlDataAccess _dataAccess;

        public PatientRepository(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public async Task<bool> AddPatientAsync(Patients patients)
        {
            throw new NotImplementedException();
        }
        public Task<int> DeletePatientAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Patients>> GetAllPatientsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Patients> GetPatientByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdatePatientAsync(Patients patient)
        {
            throw new NotImplementedException();
        }

        Task<int> IPatientRepository.AddPatientAsync(Patients patient)
        {
            throw new NotImplementedException();
        }
    }
}
