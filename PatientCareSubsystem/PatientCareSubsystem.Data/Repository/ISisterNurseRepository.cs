﻿using PatientCareSubsystem.Data.Models.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace PatientCareSubsystem.Data.Repository
{
    public interface ISisterNurseRepository
    {
        Task<bool> AddAsync(SisterNurse sisterNurse);
        Task<bool> UpdateAsync(SisterNurse sisterNurse);
        Task<bool> DeleteAsync(int id);
        Task<SisterNurse?> GetByIdAsync(int id);
        Task<IEnumerable<SisterNurse>> GetAllAsync();
    }
}
