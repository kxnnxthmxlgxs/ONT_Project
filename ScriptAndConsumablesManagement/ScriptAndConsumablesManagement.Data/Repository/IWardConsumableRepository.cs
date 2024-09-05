using ScriptAndConsumablesManagement.Data.Models;
using ScriptAndConsumablesManagement.Data.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptAndConsumablesManagement.Data.Repository
{
    public interface IWardConsumableRepository
    {
        Task<IEnumerable<Ward>> GetAllAsync();
        Task<IEnumerable<WardConsumableStockViewModel>> GetByIdAsync(int id);

    }
}
