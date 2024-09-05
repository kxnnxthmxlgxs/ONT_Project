using ProjectPractice.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractice.Data.Repository
{
    public interface IScriptDetailRepo
    {
        Task<bool> AddAsync(Script_Detail scriptDetail);
        Task<bool> UpdateAsync(Script_Detail scriptDetail);
        Task<bool> DeleteAsync(Script_Detail scriptDetail);
        Task<IEnumerable<Script_Detail>> GetAllAsync();
    }
}
