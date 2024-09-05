using ScriptAndConsumablesManagement.Data.DataAccess;
using ScriptAndConsumablesManagement.Data.Models;
using ScriptAndConsumablesManagement.Data.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptAndConsumablesManagement.Data.Repository
{
    public class WardConsumableRepository : IWardConsumableRepository
    {
        private readonly ISqlDataAccess _db;
        public WardConsumableRepository(ISqlDataAccess db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Ward>> GetAllAsync()
        {
            return await _db.GetData<Ward, dynamic>("spGetWards", new { });
        }
        public async Task<IEnumerable<WardConsumableStockViewModel>> GetByIdAsync(int Id)
        {
            return await _db.GetData<WardConsumableStockViewModel, dynamic>("spGetWardConsumables", new { Id = Id });
        }

    }
}
