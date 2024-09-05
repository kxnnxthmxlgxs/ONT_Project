using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptAndConsumablesManagement.Data.Models.ViewModels
{
    public class WardConsumableStockViewModel
    {
        public int WardConsumableStockID { get; set; }
        public string WardName { get; set; }
        public string ConsumableName { get; set; }
        public int Quantity { get; set; }
    }
}
