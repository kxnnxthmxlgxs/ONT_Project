using ProjectPractice.Data.Models.Domain;
using ScriptAndConsumablesManagement.Data.Models;
using ScriptAndConsumablesManagement.Data.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptAndConsumablesManagement.Data.Repository
{
    public interface IScriptDetailsRepo
    {
        Task<bool> UpdateAsync(Script Script);
        Task<ScriptDetailsViewModel> GetByIdAsync(int id);
        Task<IEnumerable<ScriptListViewModel>> GetAllAsync(char status);
    }
}
