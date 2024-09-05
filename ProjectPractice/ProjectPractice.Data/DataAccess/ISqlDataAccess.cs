using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractice.Data.DataAccess
{
    public interface ISqlDataAccess
    {
        Task <IEnumerable<T>> GetData<T, P>(string sp_Name, P parameters, string connectionId = "conn");
        Task SaveData<T>(string sp_Name, T parameters, string connectionId = "conn");
    }
}
