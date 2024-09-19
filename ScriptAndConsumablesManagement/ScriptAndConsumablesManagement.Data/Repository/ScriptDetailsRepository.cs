﻿using ScriptAndConsumablesManagement.Data.DataAccess;
using ScriptAndConsumablesManagement.Data.Models.ViewModels;
using ScriptAndConsumablesManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScriptAndConsumablesManagement.Data.Models.Domain;

namespace ScriptAndConsumablesManagement.Data.Repository
{
    public class ScriptDetailsRepo : IScriptDetailsRepo
    {
        private readonly ISqlDataAccess _db;
        public ScriptDetailsRepo(ISqlDataAccess db)
        {
            _db = db;
        }
        public async Task<bool> UpdateAsync(Script script)
        {
            try
            {
                var parameters = new
                {
                    Id = script.ScriptID,
                };
                await _db.SaveData("UpdateStatus", parameters);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update failed for ScriptDetailID: " + script.ScriptID + " Error: " + ex.Message);
                return false;
            }
        }
        public async Task<bool> ReceivedScriptsAsync(Script script)
        {
            try
            {
                var parameters = new
                {
                    Id = script.ScriptID,
                };
                await _db.SaveData("sp_ReceivedScripts", parameters);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update failed for ScriptDetailID: " + script.ScriptID + " Error: " + ex.Message);
                return false;
            }
        }
        public async Task<ScriptDetailsViewModel> GetByIdAsync(int id)
        {
            IEnumerable<ScriptDetailsViewModel> result = await _db.GetData<ScriptDetailsViewModel, dynamic>("DisplayNewScriptDetail", new { ID = id });
            return result.FirstOrDefault();
        }
        public async Task<IEnumerable<ScriptListViewModel>> GetAllAsync(char status)
        {
            return await _db.GetData<ScriptListViewModel, dynamic>("ListAllNewScripts", new { Status = status });
        }
        public async Task<IEnumerable<ScriptListViewModel>> GetByDateAsync(DateTime SearchDate)
        {
            return await _db.GetData<ScriptListViewModel, dynamic>("SearchByDate", new { SearchDate = SearchDate });
        }
    }
}
