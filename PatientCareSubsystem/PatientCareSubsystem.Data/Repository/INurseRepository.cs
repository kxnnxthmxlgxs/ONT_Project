using PatientCareSubsystem.Data.Models.Domain;

namespace PatientCareSubsystem.Data.Repository
{
    public interface INurseRepository
    {
        Task<bool> AddAsync(Nurse nurse);
        Task<bool> UpdateAsync(Nurse nurse);
        Task<bool> DeleteAsync(int id);
        Task<Nurse?> GetByIdAsync(int id);
        Task<IEnumerable<Nurse>> GetAllAsync();
    }
}