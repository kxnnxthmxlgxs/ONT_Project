namespace PatientCareSubsystem.Data.DataAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> GetData<T, P>(string spName, P parameters, string connectionId = "connectionString");

        Task SaveData<T>(string spName, T parameters, string connectionId = "connectionString");


    }
}