using Microsoft.Extensions.Configuration;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace PatientCareSubsystem.Data.DataAccess;

    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }


        public async Task<IEnumerable<T>> GetData<T, P>(string spName, P parameters, string connectionId = "connectionString")
        {
            try
            {
                using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
                return await connection.QueryAsync<T>(spName, parameters, commandType: CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                // Log and handle SQL-specific exceptions
                throw new Exception("Error executing stored procedure.", ex);
            }
            catch (Exception ex)
            {
                // Log and handle general exceptions
                throw new Exception("An error occurred while fetching data.", ex);
            }
        }

        public async Task SaveData<T>(string spName, T parameters, string connectionId = "connectionString")
        {
            try
            {
                using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
                await connection.ExecuteAsync(spName, parameters, commandType: CommandType.StoredProcedure);
            }
            catch (SqlException ex)
            {
                // Log and handle SQL-specific exceptions
                throw new Exception("Error executing stored procedure.", ex);
            }
            catch (Exception ex)
            {
                // Log and handle general exceptions
                throw new Exception("An error occurred while saving data.", ex);
            }
        }


}

