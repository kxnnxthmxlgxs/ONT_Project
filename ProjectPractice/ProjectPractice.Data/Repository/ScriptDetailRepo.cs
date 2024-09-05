using ProjectPractice.Data.DataAccess;
using ProjectPractice.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractice.Data.Repository
{
    public class ScriptDetailRepo : IScriptDetailRepo
    {
        private readonly ISqlDataAccess _db;
        public ScriptDetailRepo(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<bool> AddAsync(Script_Detail scriptDetail)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(Script_Detail scriptDetail)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Script_Detail>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(Script_Detail scriptDetail)
        {
            throw new NotImplementedException();
        }
    }
}
