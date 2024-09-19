using ScriptAndConsumablesManagement.Data.Models.Domain;
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
        Task<bool> UpdateStockAsync(int WardID, int ConsumableID, int Quantity);
        Task<int> AddPurchaseOrderAsync(int SupplierID, int ConsumableManagerID, int WardID);
        Task<bool> AddPurchaseOrderDetailAsync(int PurchaseOrderID, int ConsumableID, int Quantity);
        Task<bool> PurchaseUpdatetWardConsumableStock(int WardID, int ConsumableID, int Quantity);

    }
}
