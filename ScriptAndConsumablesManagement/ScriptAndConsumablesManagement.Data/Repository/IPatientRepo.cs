using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPractice.Data.Models.Domain;

namespace ProjectPractice.Data.Repository
{
    public interface IPatientRepo
    {
        Task<Patient> GetByIdAsync(int id);
        Task<IEnumerable<Patient>> GetAllAsync();
    }
}
